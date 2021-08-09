using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class ResultJobVO
    {
        public String Id { get; set; }
        public String Objective { get; set; }
        public String Slug { get; set; }
        public String Type { get; set; }
        public List<OrganizationVO> Organizations { get; set; }
        public List<String> Locations { get; set; }
        public Boolean Remote { get; set; }
        public Boolean External { get; set; }
        public Object Deadline { get; set; }
        public DateTime Created { get; set; }
        public String Status { get; set; }
        public CompensationVO Compensation { get; set; }
        public List<SkillVO> Skills { get; set; }
        public List<PersonVO> Members { get; set; }
        public List<QuestionVO> Questions { get; set; }
        public ContextVO Context { get; set; }
        public MetaVO Meta { get; set; }
    }
}
