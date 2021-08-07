using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class CompensationVO
    {
        public String Code { get; set; }
        public String Currency { get; set; }
        public Boolean Estimate { get; set; }
        public Int32 MinAmount { get; set; }
        public Int32 MaxAmount { get; set; }
        public String Periodicity { get; set; }
        public Boolean Visible { get; set; }
    }
}
