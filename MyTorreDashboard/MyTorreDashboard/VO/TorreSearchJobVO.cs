using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class TorreSearchJobVO : TorreSearchVO
    {
        public List<ResultJobVO> Results { get; set; }
    }
}
