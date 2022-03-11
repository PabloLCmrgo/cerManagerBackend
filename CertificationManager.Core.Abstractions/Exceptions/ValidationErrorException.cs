using CertificationManager.Core.Abstractions.ComonResult;
using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.Exceptions
{
#pragma warning disable S3925 // "ISerializable" should be implemented correctly
    public class ValidationErrorException : BaseException
#pragma warning restore S3925 // "ISerializable" should be implemented correctly
    {
        public ValidationErrorException(string message) : base(ResultStatus.ValidationError, message)
        {

        }
        public ValidationErrorException(string message, Dictionary<string, string> fieldMessages): base(ResultStatus.ValidationError, message, fieldMessages:fieldMessages)
        {
            
        }
    }
}
