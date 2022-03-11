using CertificationManager.Core.Abstractions.ComonResult;
using System;
using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.Exceptions
{
#pragma warning disable S3925 // "ISerializable" should be implemented correctly
    public class BaseException : Exception
#pragma warning restore S3925 // "ISerializable" should be implemented correctly
    {
        public ResultStatus StatusResult { get; set; }
        public string Global { get; set; }
        public string FailureCode { get; set; }

        public Dictionary<string, string> FieldMessages { get; set; }

        public BaseException(ResultStatus statusResult, string message) : base(message)
        {
            StatusResult = statusResult;
        }

        public BaseException(string message) : this(ResultStatus.Failure, message)
        {

        }
#pragma warning disable S3427 // Method overloads with default parameter values should not overlap 
        public BaseException(ResultStatus statusResult, string message, Dictionary<string, string> fieldMessages = null, string globalMessage = null, string failureCode = null) : this(statusResult, message)
#pragma warning restore S3427 // Method overloads with default parameter values should not overlap 
        {
            StatusResult = statusResult;
            FieldMessages = fieldMessages;
            Global = globalMessage;
            FailureCode = failureCode;

        }
    }
}
