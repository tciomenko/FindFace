using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindFace.Core.Model
{
    public class Face
    {
        [JsonProperty("galleries")]
        public List<string> Galleries { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("meta")]
        public string Meta { get; set; }
        [JsonProperty("photo")]
        public string Photo { get; set; }
        [JsonProperty("photo_hash")]
        public string PhotoHash { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
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
