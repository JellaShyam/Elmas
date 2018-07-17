using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string TalukMandal { get; set; }
        public int DistrictId { get; set; }
        public string Landmark { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactEMail { get; set; }
        public decimal Latitute { get; set; }
        public decimal Longitute { get; set; }
        public DistrictEntity DistrictEntity { get; set; }
    }
}
