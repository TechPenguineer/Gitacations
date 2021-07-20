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
using GitactionAPI;
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
            GitactionAPI.apiINFO.returnApiStatus();
        }

        private void testAPIParserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GitactionAPI.parser.parseApiInfo("TechPenguineer");
        }
    }
}
