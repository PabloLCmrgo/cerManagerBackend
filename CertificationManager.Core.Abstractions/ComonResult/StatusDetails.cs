using System.Collections.Generic;

namespace CertificationManager.Core.Abstractions.ComonResult
{
    public class StatusDetails
    {
        public string FailureCode { get; set; }
        public string Global { get; set; }
        public Dictionary<string, string> Details { get; set; }
    }
}
