using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class GroupVO
    {
        public String Id { get; set; }
        public String Text { get; set; }
        public String Answer { get; set; }
        public Int16 Order { get; set; }
        public Double Median { get; set; }
        public Double Stddev { get; set; }
    }
}
