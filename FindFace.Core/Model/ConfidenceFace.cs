using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Model
{
    public class ConfidenceFace { 
        public double confidence { get; set; }
        public Face face { get; set; }
    }
}
