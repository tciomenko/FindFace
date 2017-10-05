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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace FindFace.Core.Services
{
    public class DataService : IDataService
    {
        private string authToken = "LO42S5nEiso7VP_WScyp7nK0heIMQdT4";
        public HttpClient Client = new HttpClient();
        public static string PhotoPath;
        private const string apiBase = "https://api.findface.pro/v0/";

        //public async Task<List<ConfidenceFace>> GetDataFromService()
        //{
        //    var identify = new Identify();


        //    using (var request = new HttpRequestMessage(HttpMethod.Post,
        //        apiBase + "identify/?photo=https://pp.userapi.com/c419731/v419731917/7b68/IBkZct06cHQ.jpg"))
        //    {
        //        var jsonSerialization = JsonConvert.SerializeObject(identify);
        //        var content = new StringContent(jsonSerialization, Encoding.UTF8, "application/json");
        //        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token",
        //            "LO42S5nEiso7VP_WScyp7nK0heIMQdT4");
        //        //request.Headers.Add("Authorization", "Token _RgCyr6NtSaLFnqrzC40bUkHxgIU8KNS");
        //        var response =
        //            await Client.PostAsync(
        //                    "https://api.findface.pro/v0/identify/?photo=https://pp.userapi.com/c628131/v628131803/18520/i98Y8JoA1Do.jpg&n=10",
        //                    content)
        //                .ConfigureAwait(false);

        //        var data = new List<ConfidenceFace>();

        //        if (response.StatusCode == HttpStatusCode.OK)
        //        {
        //            var responseContent = response.Content;

        //            var json = await responseContent.ReadAsStringAsync();

        //            //data = JsonConvert.DeserializeObject<RootObject>(json);
        //            var o = JObject.Parse(json);
        //            var confidenceFace = (dynamic) o["results"].First.First;

        //            data = JsonConvert.DeserializeObject<List<ConfidenceFace>>(confidenceFace.ToString());
        //        }

        //        return data;
        //    }
        //    
        //}

        public async Task<List<ConfidenceFace>> GetDataFromService()
        {
            string filePath = await GetPhoto();
            using (var request = new HttpRequestMessage(HttpMethod.Post,
                apiBase + "identify/?"))
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token",
                    "LO42S5nEiso7VP_WScyp7nK0heIMQdT4");
                Client.DefaultRequestHeaders.TransferEncodingChunked = true;

                var content = new MultipartFormDataContent();
                var imageContent =
                    new StreamContent(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read));
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                content.Add(imageContent, "image", "image.jpg");

                var response =
                    await Client.PostAsync(
                            "https://api.findface.pro/v0/identify/?", content)
                        .ConfigureAwait(false);

                var data = new List<ConfidenceFace>();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;
                    var json = await responseContent.ReadAsStringAsync();
                    var o = JObject.Parse(json);
                    var confidenceFace = (dynamic) o["results"].First.First;
                    data = JsonConvert.DeserializeObject<List<ConfidenceFace>>(confidenceFace.ToString());
                }

                return data;
            }
        }

        public async Task<string> GetPhoto()
        {
            string filePath = null;
                if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
                {
                    MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Sample",
                        Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
                    });

                    if (file == null)
                        return null;

                    filePath = file.Path;
                    //img.Image = UIImage.FromFile(file.Path);

                }
            return filePath;
            
        }
    }
}
