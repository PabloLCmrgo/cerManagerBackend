using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{
    public enum ResultStatus
    {
        Success,
        BizFailure,
        ValidationError,
        Unauthorized,
        Failure,
        NotFound

    }
    public class BaseErrorResult: BaseResultDto
    {
        
        public BaseErrorResult(ResultStatus statusResult) : base(statusResult)
        {
            
        }

        public BaseErrorResult(ResultStatus statusResult, string message, Dictionary<string, string> details = null, string global = null, string failureCode = null): this(statusResult)
        {
            
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details,
                FailureCode = failureCode,
                Global = global
            };
        }

    }
}
