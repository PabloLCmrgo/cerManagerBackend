using CertificationManager.Core.Abstractions.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CertificationManager.Core.BussinesRules
{
    public class ValidatorBuilder<TEntity>: IValidatorBuilder<TEntity>  where TEntity:class 
    {
        protected TEntity Entity { get; private set; }

        public List<dynamic> Validators { get; set; }
        

        public ValidatorBuilder()
        {
            Validators= new List<dynamic>();

        }


        public IValidatorBuilder<TEntity> Init(TEntity entityEvent)
        {
            Entity = entityEvent;
            return this;
        }

        public IEntityValidator<TProp> WithValidator<TValidator,TProp>(TValidator validator, Expression<Func<TEntity,TProp>> propSelector) where TProp : class where TValidator : IEntityValidator<TProp>
        {

            var prop = propSelector.Compile()(Entity);
            validator.Init(prop);
            Validators.Add(validator);
            return validator;
        }
        
        public Dictionary<string, string> Build()
        {
            Dictionary<string, string> errorMessages = new Dictionary<string, string>();
            foreach (var validator in Validators)
            {
                var msgs=validator.Validate();
                foreach(var m in msgs)
                    errorMessages.Add(m.Key, m.Value);
            }
            return errorMessages;
        }
    }
}
