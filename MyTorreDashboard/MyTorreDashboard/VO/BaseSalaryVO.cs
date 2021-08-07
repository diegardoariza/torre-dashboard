using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class BaseSalaryVO
    {
        public String Type { get; set; }
        public String Currency { get; set; }
        public ValueVO Value { get; set; }
    }
}
