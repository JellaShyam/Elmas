using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectEntity
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EndClientId { get; set; }
        public string AccessId { get; set; }
        public string AccessPassword { get; set; }
        public EndClientEntity EndClientEntity { get; set; }
    }
}
