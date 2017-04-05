using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Model
{
    public class Result
    {
        
        public Bbox1 bbox1 { get; set; }
        public Bbox2 bbox2 { get; set; }
        public double confidence { get; set; }
        public bool verified { get; set; }
    }
}
