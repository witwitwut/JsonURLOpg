using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using JsonURLOpg.Service;


namespace JsonURLOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiId = "66dce85bffee4d728d2d28b3d0d63fcf";
            string link = "openexchangerates.org/api/latest.json?app_id=";

            string url = "https://" + link + apiId;

            webconnect c = new webconnect();

            Console.WriteLine(c.GetExchangeRate(url));
            Console.ReadLine();
        }
    }
}
