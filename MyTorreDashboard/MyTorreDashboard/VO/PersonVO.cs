using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    public class PersonVO
    {
        public String ProfessionalHeadline { get; set; }
        public float Completion { get; set; }
        public Boolean ShowPhone { get; set; }
        public DateTime Created { get; set; }
        public FlagsVO Flags { get; set; }
        public Double Weight { get; set; }
        public String Locate { get; set; }
        public Boolean Verified { get; set; }
        public Int32 SubjectId { get; set; }
        public String Picture { get; set; }
        public Boolean HasEmail { get; set; }
        public Boolean IsTest { get; set; }
        public Boolean HasBio { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public List<LinkVO> Links { get; set; }
        public LocationVO Location { get; set; }
        public String Theme { get; set; }
        public String Id { get; set; }
        public String PictureThumbnail { get; set; }
        public Boolean Claimant { get; set; }
        public String SummaryOfBio { get; set; }
        public String PublicId { get; set; }
        public Boolean Member { get; set; }
        public Boolean Manager { get; set; }
        public Boolean Poster { get; set; }
    }
}
