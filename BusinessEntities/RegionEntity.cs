using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RegionEntity
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CircleId { get; set; }
        public int ControlAddress { get; set; }
        public virtual CircleEntity CircleEntity { get; set; }
    }
}
