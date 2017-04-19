using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
    public class Identify
    {
        [JsonProperty("n")]
        public int N { get; set; } = 10;
        [JsonProperty("photo")]
        public string Photo { get; set; } = "https://st.kp.yandex.net/images/actor_iphone/iphone360_20866.jpg";
    }
}
