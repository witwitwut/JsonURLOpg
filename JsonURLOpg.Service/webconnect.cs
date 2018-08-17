using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace JsonURLOpg.Service
{
    public class webconnect
    {
        public Currency GetExchangeRate(string api)
        {
            Currency p;
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(api);

                p = JsonConvert.DeserializeObject<Currency>(json);
            }
            return p;
        }
    }
}
