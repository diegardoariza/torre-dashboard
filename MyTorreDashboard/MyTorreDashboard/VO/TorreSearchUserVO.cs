using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class TorreSearchUserVO:TorreSearchVO
    {
        public List<PersonVO> Results { get; set; }
    }
}
