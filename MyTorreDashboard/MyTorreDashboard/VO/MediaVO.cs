using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    class MediaVO
    {
        public String Group { get; set; }
        public String MediaType { get; set; }
        public String Description { get; set; }
        public List<MediaItemVO> MediaItems { get; set; }
    }
}
