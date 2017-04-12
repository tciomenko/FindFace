using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
    public class ConfidenceFace {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }
        [JsonProperty("face")]
        public Face Face { get; set; }
    }
}
