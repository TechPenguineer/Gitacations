using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Net;

namespace GitactionAPI
{
    public class apiINFO
    {

        public static void returnApiStatus()
        {
            string api_url = "https://api.github.com/users/techpenguineer/subscriptions";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_url);
            request.Timeout = 15000;
            request.Method = "HEAD";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        new ToastContentBuilder()
                            .AddText("API Status Request")
                            .AddText("API Status returned as OK")
                            .Show();
                    }
                    else
                    {
                        new ToastContentBuilder()
                              .AddText("API Status Request")
                              .AddText("API Status returned dead")
                               .Show();
                    }
                }
            }
            catch (WebException)
            {
                new ToastContentBuilder()
                  .AddText("API Status Request")
                  .AddText("There was an error trying to request the api")
                  .Show();
            }
        }
    }
}



