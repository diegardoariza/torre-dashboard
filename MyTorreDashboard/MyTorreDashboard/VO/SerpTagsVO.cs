using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class SerpTagsVO
    {
        public IdentifierVO Identifier { get; set; }
        public DateTime ValidThrough { get; set; }
        public List<String> EmploymentType { get; set; }
        public String Type { get; set; }
        public BaseSalaryVO BaseSalary { get; set; }
        public String Description { get; set; }
        public String Title { get; set; }
        public String Context { get; set; }
        public String JobLocationType { get; set; }
        public Boolean ExperienceInPlaceOfEducation { get; set; }
        public OrganizationVO HiringOrganization { get; set; }
        public List<EducationalRequirementVO> EducationslRequirements { get; set; }
        public DateTime DatePosted { get; set; }
        public ExperienceRequiredVO ExperienceRequirements { get; set; }
        public List<ApplicantLocationRequirementVO> ApplicantLocationRequirements { get; set; }
    }
}
