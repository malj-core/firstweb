using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WeChat.WebApi.Utils
{
    public class HttpHelper
    {
        public static string GetResponse(string url)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = httpClient.GetAsync(url).Result;
            return response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync().Result : null;
        }

        public static T GetResponse<T>(string url) where T : class, new()
        {
            var responseResult = GetResponse(url);
            return responseResult != null ? JsonConvert.DeserializeObject<T>(responseResult) : null;
        }
    }
}
