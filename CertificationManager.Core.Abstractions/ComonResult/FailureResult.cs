using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{

    public class FailureResult : BaseErrorResult
    {
        public FailureResult() : base(ResultStatus.Failure)
        {

        }
        public FailureResult(string message, Dictionary<string, string> details) : this()
        {
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details
            };
        }

        public FailureResult(string message, Dictionary<string, string> details = null, string global = null, string failureCode = null) : this()
        {
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details,
                FailureCode = failureCode,
                Global = global
            };
        }

        public FailureResult(string message, StatusDetails statusDetail) : this()
        {
            Message = message;
            StatusDetails = statusDetail;
        }




    }
}
