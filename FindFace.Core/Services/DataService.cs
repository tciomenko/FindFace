using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using FindFace.Core.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using MvvmCross.Binding.Binders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FindFace.Core.Services
{
    public class DataService : IDataService
    {
        string authToken = "_RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS";
        public HttpClient Сlient = new HttpClient();


        public async Task<List<ConfidenceFace>> GetDataFromService()
        {
            var identify = new Identify();


            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,
                "https://api.findface.pro/v0/identify/?photo=http://static.findface.pro/sample.jpg"))
            {
                string jsonSerialization = JsonConvert.SerializeObject(identify);
                var content = new StringContent(jsonSerialization, Encoding.UTF8, "application/json");
                Сlient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token",
                    "_RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS");
                //request.Headers.Add("Authorization", "Token _RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS");
                var response =
                    await Сlient.PostAsync(
                            "https://api.findface.pro/v0/identify/?photo=http://static.findface.pro/sample.jpg", content)
                        .ConfigureAwait(false);
                ;
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

        
        //public async Task<FaceResponse> GetDataFromService()
        //{
        //    var url = "https://api.findface.pro/v0/galleries/?";
        //    Сlient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", "token: " + authToken);

        //    var response = await Сlient.GetAsync(url);
        //    response = response; // зачем ты это делаешь??
        //    FaceResponse data = new FaceResponse();
        //    try
        //    {
        //        if (response != null)
        //        {

        //            string json = response.Content.ReadAsStringAsync().Result;
        //            data = JsonConvert.DeserializeObject<FaceResponse>(json);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message, ex.StackTrace);
        //    }

        //    return data;


        //}


    }
}
