using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
    public class Bbox2
    {
        [JsonProperty("x1")]
        public int X1 { get; set; }
        [JsonProperty("x2")]
        public int X2 { get; set; }
        [JsonProperty("y1")]
        public int Y1 { get; set; }
        [JsonProperty("y2")]
        public int Y2 { get; set; }

    }
}
