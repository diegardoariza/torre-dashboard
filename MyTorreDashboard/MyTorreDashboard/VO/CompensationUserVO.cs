using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class CompensationUserVO
    {
        public CompensationVO Freelancer { get; set; }
        public CompensationVO Intern { get; set; }
        public CompensationVO EMployee { get; set; }
    }
}
