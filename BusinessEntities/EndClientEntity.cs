﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EndClientEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrimeVendor { get; set; }
        public PrimeVendorEntity PrimeVendorEntity { get; set; }

    }
}
