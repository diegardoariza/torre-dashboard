using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class MembersVO
    {
        public String Id { get; set; }
        public PersonVO Person { get; set; }
        public Boolean Manager { get; set; }
        public Boolean Poster { get; set; }
        public Boolean Member { get; set; }
        public String Status { get; set; }
        public Boolean Visible { get; set; }
    }
}
