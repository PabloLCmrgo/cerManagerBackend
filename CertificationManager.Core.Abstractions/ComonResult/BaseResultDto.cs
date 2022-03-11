namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class BaseResultDto
    {
        public ResultStatus StatusResult { get; set; } = ResultStatus.Success;
        public string Status { set; get; }

        public string Message { get; set; }
        public StatusDetails StatusDetails { get; set; }
        public BaseResultDto(ResultStatus statusResult)
        {
            StatusResult = statusResult;
        }
        public BaseResultDto()
        {

        }
    }
}
