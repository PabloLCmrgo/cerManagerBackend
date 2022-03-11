using System.Collections.Generic;
using System.Text.Json.Serialization;
//using System.Text.Json.Serialization;

namespace CertificationManager.Shared.Models.Filter
{
    public class BaseSearchFilter<TFilter, T> where TFilter : struct
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TFilter Criteria { get; set; }
        public ICollection<T> Ids { get; set; }
    }
}
