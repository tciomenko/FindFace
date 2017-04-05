using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Model
{
    public class FaceResponse
    {
        public List<Result> results { get; set; }
        public bool verified { get; set; }
        
    }
}
