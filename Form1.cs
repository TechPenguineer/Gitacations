using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Net;
namespace Gitacations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendTestNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               new ToastContentBuilder()
                    .AddText("Gitacations")
                    .AddText("Test notificaion successfully sent")
                    .Show();
            }
            catch(Exception)
            {
                
            }
        }

        private void checkAPIStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string api_url = "https://api.github.com/users/techpenguineer/subscriptions";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_url);
            request.Timeout = 15000;
            request.Method = "HEAD";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                {
                    if(response.StatusCode == HttpStatusCode.OK)
                    {
                        new ToastContentBuilder()
                            .AddText("API Status Request")
                            .AddText("API Status returned as OK")
                            .Show();
                    } else 
                    {
                        new ToastContentBuilder()
                              .AddText("API Status Request")
                              .AddText("API Status returned dead")
                               .Show();
                    }
                }
            }catch(WebException)
            {
                new ToastContentBuilder()
                  .AddText("API Status Request")
                  .AddText("There was an error trying to request the api")
                  .Show();
            }
        }
    }
}
