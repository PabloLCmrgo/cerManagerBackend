using CertificationManager.Core.Abstractions.ComonResult;

namespace CertificationManager.Core.Builders
{
    public class ResultDtoBuilder<T>
    {
        private string Message { get; set; }
        private T Result { get; set; }

        public ResultDto<T> Build()
        {
            return new ResultDto<T> { Message = this.Message, Result = this.Result };
        }

        public static ResultDtoBuilder<T> Create() => new ResultDtoBuilder<T>();

        public ResultDtoBuilder<T> WithMessage(string message)
        {
            this.Message = message;
            return this;
        }

        public ResultDtoBuilder<T> WithSuccess()
        {
            return this;
        }

        public ResultDtoBuilder<T> WithData(T data)
        {
            this.Result = data;
            return this;
        }

        public ResultDtoBuilder<T> WithPropertyNullMessage(string propertyName)
        {
            this.Message = $"{propertyName} can not be null";
            return this;
        }

    }
}
