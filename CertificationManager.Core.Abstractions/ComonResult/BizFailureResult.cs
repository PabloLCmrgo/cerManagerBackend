using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class BizFailureResult: BaseErrorResult
    {
        public BizFailureResult(): base(ResultStatus.ValidationError)
        {

        }
        public BizFailureResult(string message, Dictionary<string, string> details) : this()
        {
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details
            };
        }

        public BizFailureResult(string message, Dictionary<string, string> details=null , string global= null, string failureCode=null) : this()
        {
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details,
                FailureCode= failureCode,
                Global= global
            };
        }

        public BizFailureResult(string message, StatusDetails statusDetail) : this()
        {
            Message = message;
            StatusDetails = statusDetail;
        }

        

        
    }
}
