using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.BusinessRules
{
    public interface IEntityValidator<T> where T:class
    {
        IEntityValidator<T> Init(T obj);
        IEntityValidator<T> Exists();
        IEntityValidator<T> NotNull();
        Dictionary<string, string> Validate();


    }
}
