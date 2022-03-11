using System.Collections.Generic;

namespace CertificationManager.Shared.Models.Filter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSearch">Searchable Class</typeparam>
    /// <typeparam name="TFilter">Filter Criteria Enum</typeparam>
    /// <typeparam name="TId">Filter Ids Data type</typeparam>
    public class BaseSearchRequest<TSearch, TFilter, TId> where TSearch : ISearchable where TFilter : struct
    {
        public IEnumerable<BaseSearchFilter<TFilter, TId>> Filters { get; set; }
        public TSearch Search { get; set; }
    }
}
