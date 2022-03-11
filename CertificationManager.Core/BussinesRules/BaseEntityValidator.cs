using CertificationManager.Core.Resources;
using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using CertificationManager.Infrastructure.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CertificationManager.Core.BussinesRules
{
    public class BaseEntityValidator<TEntity> where TEntity: class
    {
        protected TEntity Entity { get; set; }
        protected List<Action> Validations { get; set; }
        protected Dictionary<string, string> ErrorMessages { get; set; }
        public BaseEntityValidator()
        {
            Validations = new List<Action>();
            ErrorMessages= new Dictionary<string, string>();
        }

        protected void NotNullImpl(string nameProperty, Expression<Func<TEntity,Guid?>> propSelector)
        {
            
            bool hasValue=false;
            try
            {
                var id = propSelector.Compile()(Entity);
                hasValue = (id.HasValue && !id.Value.Equals(Guid.Empty));                    
            }
            catch (NullReferenceException)
            {
              //      
            }
            finally
            {
                if (!hasValue)
                {
                    ErrorMessages.Add(nameProperty, ResourceKeys.EntityNotFound);
                }
                        
            }
        }

        

        protected  void  ExistsImpl<TDBEntity>(IGenericRepository<TDBEntity> repo, string nameProperty, Expression<Func<TEntity, Guid>> idSelector) where TDBEntity:BaseEntity
        {
            if (Entity == null)
            {
                ErrorMessages.Add(nameProperty, ResourceKeys.EntityNotFound);
            }
            else
            {
                var id = idSelector.Compile()(Entity);
                var objExists = repo.GetByIdAsync(id).Result;
                if (objExists == null)
                    ErrorMessages.Add(nameProperty, ResourceKeys.EntityNotFound);
            }
        }

        public Dictionary<string, string> Validate()
        {
            foreach(var v in Validations)
            {
                v();
                if (ErrorMessages.Count > 0)
                    break;
            }
            return ErrorMessages;
        }
    }
}
