using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Model
{
    public class Face
    {
        public List<string> galleries { get; set; }
        public int id { get; set; }
        public string meta { get; set; }
        public string photo { get; set; }
        public string photo_hash { get; set; }
        public string thumbnail { get; set; }
        public string timestamp { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
    }
}
