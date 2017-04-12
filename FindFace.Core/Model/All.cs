using System;
using System.Collections.Generic;
using System.Text;

namespace FindFace.Core.Model
{
    public class All
    {
        public class Rootobject
        {
            public Results results { get; set; }
        }

        public class Results
        {
            public List<_419236345311> _419236345311 { get; set; }
        }

        public class _419236345311
        {
            public float confidence { get; set; }
            public Face face { get; set; }
        }

        public class Face
        {
            public string[] galleries { get; set; }
            public int id { get; set; }
            public string meta { get; set; }
            public string photo { get; set; }
            public string photo_hash { get; set; }
            public string thumbnail { get; set; }
            public DateTime timestamp { get; set; }
            public int x1 { get; set; }
            public int x2 { get; set; }
            public int y1 { get; set; }
            public int y2 { get; set; }
        }

    }
}
