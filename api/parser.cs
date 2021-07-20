using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System;
namespace GitactionAPI
{
    public class parser
    {
        public static void parseApiInfo(string Username)
        {
            string api_url = $"https://api.github.com/users/{Username}/subscriptions";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(api_url);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(api_url).Result;

            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                var s = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
            }

        }
    }
}
