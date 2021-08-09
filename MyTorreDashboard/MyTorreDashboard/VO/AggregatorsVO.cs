using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class AggregatorsVO
    {
        public List<AggregatorsItemVO> Remote { get; set; }
        public List<AggregatorsItemVO> Organization { get; set; }
        public List<AggregatorsItemVO> Skill { get; set; }
        public List<AggregatorsItemVO> Compensationrange { get; set; }
        public List<AggregatorsItemVO> Type { get; set; }
        public List<AggregatorsItemVO> Status { get; set; }
        public List<AggregatorsItemVO> Location { get; set; }
    }
}
