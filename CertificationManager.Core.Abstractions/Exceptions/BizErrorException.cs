using CertificationManager.Core.Abstractions.ComonResult;
using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.Exceptions
{
#pragma warning disable S3925 // "ISerializable" should be implemented correctly
    public class BizErrorException : BaseException
#pragma warning restore S3925 // "ISerializable" should be implemented correctly
    {
        public BizErrorException(string message) : base(ResultStatus.BizFailure, message)
        {

        }
#pragma warning disable S3427 // Method overloads with default parameter values should not overlap 
        public BizErrorException(string message, Dictionary<string, string> fieldMessages = null, string globalMessage = null, string failureCode = null) : base(ResultStatus.BizFailure, message, fieldMessages, globalMessage, failureCode)
#pragma warning restore S3427 // Method overloads with default parameter values should not overlap 
        {


        }
    }
}
