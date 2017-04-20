using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FindFace.Core.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Foundation;
using MvvmCross.Binding.Binders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FindFace.Core.Services
{
    public class DataService : IDataService
    {
        string authToken = "LO42S5nEiso7VP_WScyp7nK0heIMQdT4";
        public HttpClient Client = new HttpClient();
        private const string apiBase = "https://api.findface.pro/v0/";
        private NSUrlSession syncSession = null;
        public async Task<List<ConfidenceFace>> GetDataFromService()
        {
            var identify = new Identify();


            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,
                apiBase+"identify/?photo=https://pp.userapi.com/c419731/v419731917/7b68/IBkZct06cHQ.jpg"))
            {
                string jsonSerialization = JsonConvert.SerializeObject(identify);
                var content = new StringContent(jsonSerialization, Encoding.UTF8, "application/json");
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token",
                    "LO42S5nEiso7VP_WScyp7nK0heIMQdT4");
                //request.Headers.Add("Authorization", "Token _RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS");
                var response =
                    await Client.PostAsync(
                            "https://api.findface.pro/v0/identify/?photo=https://pp.userapi.com/c628131/v628131803/18520/i98Y8JoA1Do.jpg&n=10", content)
                        .ConfigureAwait(false);
                
                var data = new List<ConfidenceFace>();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    HttpContent responseContent = response.Content;

                    var json = await responseContent.ReadAsStringAsync();

                    //data = JsonConvert.DeserializeObject<RootObject>(json);
                    JObject o = JObject.Parse(json);
                    var confidenceFace = (dynamic)o["results"].First.First;
                    
                    data = JsonConvert.DeserializeObject<List<ConfidenceFace>>(confidenceFace.ToString());
                    



                }
                
                return data;
            }
            ;
        }

        public async Task<List<ConfidenceFace>> GetDataFromService(string s="")
        {
            var identify = new Identify();


            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,
                apiBase + "identify/?photo=https://pp.userapi.com/c419731/v419731917/7b68/IBkZct06cHQ.jpg"))
            {
                string jsonSerialization = JsonConvert.SerializeObject(identify);
                
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token",
                    "LO42S5nEiso7VP_WScyp7nK0heIMQdT4");
                Client.DefaultRequestHeaders.TransferEncodingChunked = true;

                var content = new MultipartFormDataContent();
                var imageContent = new StreamContent(new FileStream("my_path.jpg", FileMode.Open, FileAccess.Read, FileShare.Read));
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                content.Add(imageContent, "image", "image.jpg");

                var response =
                    await Client.PostAsync(
                            "https://api.findface.pro/v0/identify/?photo=https://pp.userapi.com/c628131/v628131803/18520/i98Y8JoA1Do.jpg&n=10", content)
                        .ConfigureAwait(false);

                var data = new List<ConfidenceFace>();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    HttpContent responseContent = response.Content;

                    var json = await responseContent.ReadAsStringAsync();

                    //data = JsonConvert.DeserializeObject<RootObject>(json);
                    JObject o = JObject.Parse(json);
                    var confidenceFace = (dynamic)o["results"].First.First;

                    data = JsonConvert.DeserializeObject<List<ConfidenceFace>>(confidenceFace.ToString());




                }

                return data;
            }
            
        }



    }
}
