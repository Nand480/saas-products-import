using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaaS_Products_Import
{
    //Requirement 4: created some code that echoes that it is storing data
    public class Storage
    {
        private List<string> products = new List<string>();
        public void DataStore(string data)
        {
            Console.WriteLine($"Storing Data for {data}");
            products.Add(data);

        }

        public List<string> GetStoredData()
        {
            return products;
        }
    }
}
