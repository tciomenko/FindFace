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

namespace FindFace.Core.Services
{
    public class DataService : IDataService
    {       const string Key = "_RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS";
            const string WeatherCoordinatesUri = "http://api.findface.pro/v0/detect/?";
            string result = "";

        public async Task<FaceResponse> GetDataFromService()
        {
            
          using (var client = new HttpClient())
            {
                var url = "https://api.findface.pro/v0/detect?photo=http://static.findface.pro/sample.jpg";
                client.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Authorization", "toket " + Key);
                client.DefaultRequestHeaders.Host = "api.findface.pro";
                
                var response = await client.GetAsync(url);
                FaceResponse data = null;
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
}
