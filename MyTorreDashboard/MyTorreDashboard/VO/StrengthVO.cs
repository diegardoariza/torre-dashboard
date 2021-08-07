using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class StrengthVO
    {
        public String Id { get; set; }
        public Int32 Code { get; set; }
        public String Name { get; set; }
        public Double Weight { get; set; }
        public Int32 Recomendations { get; set; }
        public List<Object> Media { get; set; }
        public Boolean Supra { get; set; }
        public DateTime Created { get; set; }
        public String Experience { get; set; }
    }
}
