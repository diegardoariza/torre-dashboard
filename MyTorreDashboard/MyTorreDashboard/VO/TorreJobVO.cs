using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class TorreJobVO
    {
        public List<AttachementVO> Attachements { get; set; }
        public Int32 BoardVersion { get; set; }
        public PrefiledStatusVO PrefiledStatus { get; set; }
        public String Locale { get; set; }
        public String Objective { get; set; }
        public StatsVO Stats { get; set; }
        public String Review { get; set; }
        public Object Draft { get; set; }
        public List<MembersVO> Members { get; set; }
        public List<DetailVO> Details { get; set; }
        public String Id { get; set; }
        public PlaceVO Place { get; set; }
        public DateTime Deadline { get; set; }
        public String Slug { get; set; }
        public SerpTagsVO SerpTags { get; set; }
        public PersonVO Owner { get; set; }
        public Double Completion { get; set; }
        public AgreementVO Agreement { get; set; }
        public List<JobLanguageVO> Languages { get; set; }
        public DateTime Created { get; set; }
        public Boolean Crawled { get; set; }
        public String Opportunity { get; set; }
        public Boolean Active { get; set; }
        public CommitmentVO Commitment { get; set; }
        public DateTime StableOn { get; set; }
        public List<String> Timezones {get; set;}
        public List<StrengthVO> Strengths { get; set; }
        public List<OrganizationVO> Organizations { get; set; }
        public CompensationVO Compensation { get; set; }
        public String OpenGraph { get; set; }
        public String Status { get; set; }
    }
}
