using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class ResultUserVO
    {

        public ContextVO Context { get; set; }
        public MetaVO Meta { get; set; }
        public CompensationUserVO Compensation { get; set; }
        public String Locationname { get; set; }
        public String Name { get; set; }
        public List<String> OpenTo { get; set; }
        public String Picture { get; set; }
        public String ProfessionalHeadeline { get; set; }
        public Boolean Remoter { get; set; }
        public List<SkillVO> Skills { get; set; }
        public String SubjectId { get; set; }
        public String Username { get; set; }
        public Boolean Verified { get; set; }
        public Double Weight { get; set; }
    }
}
