using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class PlaceVO
    {
        public Boolean Remote { get; set; }
        public Boolean Anywhere { get; set; }
        public Boolean TimeZone { get; set; }
        public List<LocationVO> Location { get; set; }
    }
}
