using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class FilterOptions
    {
        public SortingPagingInfo SortingPagingInfo { get; set; }
        public List<int> SiteIdList { get; set; }

    }
}
