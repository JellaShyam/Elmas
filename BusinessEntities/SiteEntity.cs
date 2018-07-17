using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SiteEntity
    {
        public int Id { get; set; }
        public string SiteId { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int StatusId { get; set; }
        public int ProjectId { get; set; }
        public string MobileNumber { get; set; }
        public string SIMNumber { get; set; }
        public string SIMNetworkDetails { get; set; }
        public string SIMAPNDetails { get; set; }
        public string IEMINumber { get; set; }
        public int DivisionId { get; set; }
        public string Description { get; set; }
        public AddressEntity AddressEntity { get; set; }
        public SiteStatusEntity SiteStatusEntity { get; set; }
        public DivisionEntity DivisionEntity { get; set; }
    }
}
