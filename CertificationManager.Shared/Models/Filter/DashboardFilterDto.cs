using System;
using System.Collections.Generic;

namespace CertificationManager.Shared.Models.Filter
{ 
    public class DashboardFilterDto
    {
        public FilterCriteriaDto Criteria { get; set; }
        public ICollection<Guid> Ids { get; set; }
    }
}
