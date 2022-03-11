using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class ResultDto<T> : BaseResultDto
    {
        public T Result { get; set; }
        public Dictionary<string, string> Meta { get; set; }
        public ResultDto(T result) : base(ResultStatus.Success)
        {
            Result = result;

        }
        public ResultDto(T result, string message) : this(result)
        {
            Message = message;

        }
        public ResultDto(T result, string message, Dictionary<string, string> meta) : this(result, message)
        {
            Result = result;
            Meta = meta;
        }
        public ResultDto()
        {

        }
       
    }
}
