using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class TorreSearchVO
    {
        public AggregatorsVO Aggregators { get; set; }
        public Int32 Offset { get; set; }
        public Int32 Size { get; set; }
        public Int32 Total { get; set; }
        public PaginationVO Pagination { get; set; }
    }
}
