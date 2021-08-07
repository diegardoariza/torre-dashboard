using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class ExperienceVO
    {
        public String Id { get; set; }
        public String Category { get; set; }
        public String Name { get; set; }
        public String Contributions { get; set; }
        public List<OrganizationVO> Organizations { get; set; }
        public List<String> Responsabilities { get; set; }
        public String FromMonth { get; set; }
        public String FromYear { get; set; }
        public String ToMonth { get; set; }
        public Double ToYear { get; set; }
        public String AdditionalInfo { get; set; }
        public Boolean Remote { get; set; }
        public Boolean HIghlighted { get; set; }
        public Double Weight { get; set; }
        public Int16 Verifications { get; set; }
        public Int16 Recommendations { get; set; }
        public List<MediaVO> Media { get; set; }
        public Int16 Rank { get; set; }
    }
}
