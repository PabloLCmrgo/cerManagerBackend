using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CertificationManager.Core.Abstractions.BusinessRules
{
    
    public interface IValidatorBuilder<TEntity> where TEntity:class
    {
        IValidatorBuilder<TEntity> Init(TEntity entityEvent);
        IEntityValidator<TProp> WithValidator<TValidator, TProp>(TValidator validator, Expression<Func<TEntity, TProp>> propSelector) where TProp : class where TValidator : IEntityValidator<TProp>;

        Dictionary<string, string> Build();
    }
}
