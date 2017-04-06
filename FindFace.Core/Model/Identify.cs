using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Model
{
    public class Identify
    {
        public string Photo { get; set; } = "http://static.findface.pro/sample.jpg";
        public int N { get; set; } = 10;
    }
}
