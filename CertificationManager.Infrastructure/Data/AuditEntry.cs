using System.Collections.Generic;

namespace CertificationManager.Infrastructure.Data
{
    public class AuditEntry
    {
        public string ActionType { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, object> Values { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> Keys { get; } = new Dictionary<string, object>();
    }
}
