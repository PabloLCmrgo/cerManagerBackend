using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TimeZoneConverter;

namespace CertificationManager.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime? ToDateTime(this DateTimeOffset? input)
        {
            if (!input.HasValue)
            {
                return null;
            }
            return input.Value.DateTime;
        }
    }
}
