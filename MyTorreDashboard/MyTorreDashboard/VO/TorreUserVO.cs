using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class TorreUserVO
    {
        public PersonVO Person { get; set; }
        public StatsVO Stats { get; set; }
        public List<StrengthVO> Strengths { get; set; }
        public List<InterestVO> Interests { get; set; }
        public List<ExperienceVO> Experiences { get; set; }
        public List<ExperienceVO> Awards { get; set; }
        public List<ExperienceVO> Jobs { get; set; }
        public List<ExperienceVO> Projects { get; set; }
        public List<ExperienceVO> Publications { get; set; }
        public List<ExperienceVO> Education { get; set; }
        public List<OpportunityVO> Opportunities { get; set; }
        public List<LanguageVO> Languages { get; set; }
        public PersonalityTraitsResultsVO PersonalityTraitsResults { get; set; }
        public ProfessionalCultureGenomeResultsVO ProfessionalCultureGenomeResults { get; set; }
    }
}
