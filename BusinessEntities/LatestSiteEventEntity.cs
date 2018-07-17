using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LatestSiteEventEntity
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int EventId { get; set; }
        public System.DateTime EventDate { get; set; }
        public SiteEventEntity SiteEventEntity { get; set; }
    }
}
