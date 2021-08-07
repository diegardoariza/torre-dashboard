using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class InterestVO
    {
        public String Id { get; set; }
        public Int32 Code { get; set; }
        public String Name { get; set; }
        public List<MediaVO> Media { get; set; }
        public DateTime Created { get; set; }
    }
}
