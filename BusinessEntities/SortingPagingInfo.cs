﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SortingPagingInfo
    {

        public string SortField { get; set; }
        public string SortDirection { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public int CurrentPageIndex { get; set; }

    }
}
