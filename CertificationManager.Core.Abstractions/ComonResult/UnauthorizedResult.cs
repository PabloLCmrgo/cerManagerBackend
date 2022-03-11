namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class UnauthorizedResult: BaseErrorResult
    {
        public UnauthorizedResult(): base(ResultStatus.Unauthorized) { }
    }
}
