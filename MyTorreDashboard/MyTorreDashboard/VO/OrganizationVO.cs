using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class OrganizationVO
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Size { get; set; }
        public String PublicId { get; set; }
        public String Picture { get; set; }
        public String Websiteurl { get; set; }
        public String Type { get; set; }
        public String Logo { get; set; }
        public String SameAs { get; set; }
    }
}
