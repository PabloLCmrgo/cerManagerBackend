using CertificationManager.Core.Abstractions.ComonResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationManager.Core.Abstractions.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) : base(ResultStatus.NotFound, message)
        {

        }
        public NotFoundException(string message, Dictionary<string, string> fieldMessages) : base(ResultStatus.NotFound, message, fieldMessages: fieldMessages)
        {

        }
    }
}
