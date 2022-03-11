using System.Collections.Generic;
using System.Linq;

namespace CertificationManager.Infrastructure.Abstractions.CommonResult
{
    public class PagedList<T>: List<T>
    { 
        public PageMeta Meta { get; set; }
        public List<T> Data { get; set; }

        public PagedList(List<T> data, int count)
        {
            
            Data = data;
            Meta = new PageMeta
            {
                Count = data.Count(),
                Total = count
            };
        }
    }



}
