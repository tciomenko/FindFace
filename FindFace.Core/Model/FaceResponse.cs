using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
    public class FaceResponse
    {
        [JsonProperty("results")]
        public List<Results> Results { get; set; }
        [JsonProperty("verified")]
        public bool Verified { get; set; }
        
    }
}
