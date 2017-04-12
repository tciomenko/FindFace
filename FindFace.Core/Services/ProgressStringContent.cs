using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FindFace.Core.Services
{
    public class ProgressStringContent : HttpContent
    {
        private string jsonSerialization;
        private Encoding uTF8;
        private string v;
        private Action<double> actionProgress;

        public ProgressStringContent(string jsonSerialization, Encoding uTF8, string v)
        {
            this.jsonSerialization = jsonSerialization;
            this.uTF8 = uTF8;
            this.v = v;
        }

        public ProgressStringContent(string jsonSerialization, Encoding uTF8, string v, Action<double> actionProgress)
        {
            this.jsonSerialization = jsonSerialization;
            this.uTF8 = uTF8;
            this.v = v;
            this.actionProgress = actionProgress;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            throw new System.NotImplementedException();
        }

        protected override bool TryComputeLength(out long length)
        {
            throw new System.NotImplementedException();
        }
    }
}