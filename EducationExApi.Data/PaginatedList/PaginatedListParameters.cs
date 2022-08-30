﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationExApi.Data.PaginatedList
{
    public class PaginatedListParameters
    {
        private const int maxPageSize = 5;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 3;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
