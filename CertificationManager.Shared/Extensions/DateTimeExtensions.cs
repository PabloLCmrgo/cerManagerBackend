using System;

namespace CertificationManager.Shared.Extensions
{
    
    public static class DateTimeExtensions
    {
        public static bool IsDateNullOrMin(this DateTimeOffset? dt)
        {
            return dt == null || dt.Value == DateTime.MinValue;
        }
        public static bool IsDateNullOrMin(this DateTime? dt)
        {
            return dt == null || dt.Value == DateTime.MinValue;
        }
    }
}
