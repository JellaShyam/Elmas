using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class DivisionEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        public int ControlAddress { get; set; }
        public RegionEntity RegionEntity { get; set; }
    }
}
