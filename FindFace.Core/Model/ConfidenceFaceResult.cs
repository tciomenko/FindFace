using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
   public class ConfidenceFaceResult
    {
        [JsonProperty("confidenceFace")]
        public List<ConfidenceFace> ConfidenceFace { get; set; }
    }
}
