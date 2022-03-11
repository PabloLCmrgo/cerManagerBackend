using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class ValidationErrorResult : BaseErrorResult
    {
        public ValidationErrorResult() : base(ResultStatus.ValidationError)
        {

        }

        public ValidationErrorResult(string message, Dictionary<string, string> details) : this()
        {
            Message = message;
            StatusDetails = new StatusDetails
            {
                Details = details
            };
        }

        public ValidationErrorResult(string message, StatusDetails statusDetail) : this()
        {
            Message = message;
            StatusDetails = statusDetail;
        }
    }
}
