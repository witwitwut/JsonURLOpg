using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonURLOpg
{
    public class Currency
    {
        private string disclaimer;
        private string license;
        private int timestamp;
        private string @base;
        private Dictionary<string, decimal> rates = new Dictionary<string, decimal>();

        public string Base
        {
            get { return @base; }
            set { @base = value; }
        }




        public int Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }


        public string License
        {
            get { return license; }
            set { license = value; }
        }


        public string Disclaimer
        {
            get { return disclaimer; }
            set { disclaimer = value; }
        }

        public Dictionary<string, decimal> Rates { get => rates; set => rates = value; }

        public override string ToString()
        {
            Console.WriteLine(disclaimer);
            Console.WriteLine(license);
            Console.WriteLine(timestamp);
            Console.WriteLine(@base);
            foreach (var item in rates)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            return "slut";
        }
    }
}
