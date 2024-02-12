using System.Net.Http;
using System;
 
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Library;

namespace WebService
{
    public class RestApi
    {
        string _uri = "";
        string apikey = "";
        public RestApi()
        {
            _uri = Configuration.API_URL;
            apikey = Configuration.API_KEY;
        }
        public T Rest<T>(object param, string url, string method) where T : new()
        {
            HttpMethod httpMethod= HttpMethod.Post;
            if(method=="Post")
                httpMethod = HttpMethod.Post;
            if (method == "Get")
                httpMethod = HttpMethod.Get;

            HttpClient client = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, _uri + url);
            string body = JsonSerializer.Serialize(param);
            var requestContent = new StringContent(body, Encoding.UTF8, "application/json");
            if(method=="Post")
            httpRequestMessage.Content = requestContent;
            httpRequestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", apikey);
            HttpResponseMessage response = client.SendAsync(httpRequestMessage).GetAwaiter().GetResult();
            var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            return JsonSerializer.Deserialize<T>(responseString, options);
        }
    }
}