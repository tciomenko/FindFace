using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFace.Core.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using Chance.MvvmCross.Plugins.UserInteraction;
using MvvmCross.Binding.ExtensionMethods;


namespace FindFace.Core.Services
{
    public class DataService : IDataService
    {
         string Key = "_RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS";
       public HttpClient client = new HttpClient();

        public DataService(string key= "_RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS")
        {
            this.Key = key;
        }
        public async Task<RootOject> SendPost()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.findface.pro/v0/identify/?");
            request.Method = HttpMethod.Post;
            var identify = new Identify();
            // сериализация объекта с помощью Json.NET
            string json2 = JsonConvert.SerializeObject(identify);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Token _RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS");

            RootOject data = new RootOject();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent =new StringContent(json2); ;
                var json = await responseContent.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<RootOject>(json);
            }
            return data;
        }
        public async Task<FaceResponse> GetDataFromService()
        {
            var url = "https://api.findface.pro/v0/galleries/?";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", "token: " + Key);
            
            var response = await client.GetAsync(url);
            response = response;
            FaceResponse data = new FaceResponse();
            try
            {
                if (response != null)
                {

                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject<FaceResponse>(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }

            return data;


        }


    }
}
