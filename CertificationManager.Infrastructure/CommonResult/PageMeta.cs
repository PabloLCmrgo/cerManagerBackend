using System.Collections.Generic;

namespace CertificationManager.Infrastructure.Abstractions.CommonResult
{
    public class PageMeta
    {
        public int Total { get; set; }
        public int Count { get; set; }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>()
            {
                { "total", Total.ToString() },
                { "count", Count.ToString() }
            };
        }
    }
}
