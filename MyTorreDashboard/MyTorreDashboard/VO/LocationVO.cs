using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    public class LocationVO
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
        public String Country { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public String Timezone { get; set; }
        public Int32 timezoneOffSet { get; set; }
    }
}
