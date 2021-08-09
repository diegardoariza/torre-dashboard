using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class RankerVO
    {
        public String Type { get; set; }
        public Int32 Rank { get; set; }
        public String Score { get; set; }
        public InputVO Input { get; set; }
        public InputVO And { get; set; }
    }
}
