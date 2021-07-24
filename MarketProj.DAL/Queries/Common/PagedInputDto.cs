using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Queries.Common
{
    public class PagedInputDto
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
