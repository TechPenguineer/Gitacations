using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitactionAPI
{
    public class parser
    {
        public static void parseApiInfo(string Username)
        {
            string api_url = $"https://api.github.com/users/{Username}/subscriptions";
        }
    }
}
