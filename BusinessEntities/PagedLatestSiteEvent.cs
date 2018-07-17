using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class PagedLatestSiteEvent
    {
        public string SortDirection { get; set; }
        public int PageSize { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
        public string SortField { get; set; }
        public List<LatestSiteEventEntity> MinifiedLatestSiteEvents { get; set; }
    }
}
