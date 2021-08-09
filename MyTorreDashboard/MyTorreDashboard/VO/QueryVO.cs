using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class QueryVO
    {
        public String offset {get; set;}
        public String size {get; set;}
        public String aggregate { get; set; } 
    }
}
