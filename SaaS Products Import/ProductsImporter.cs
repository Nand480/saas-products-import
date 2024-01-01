using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaaS_Products_Import
{
    public class ProductsImporter
    {
        //Requirement 3: we can scale this up by adding more file formats and their separate extraction functions, for eg: csv through a url
        public void Process (string provider, string file_path)
        {
            switch (provider.ToLower())
            {
                case "capterra":
                    Importcapterra(file_path);   
                    break;
                case "softwareadvice":
                    Importsoftwareadvice(file_path);
                    break;
                default:
                    Console.WriteLine("Provider doesn't exist");
                    break;
            }
        }

        private void Importcapterra (string file_path)
        {
            if(Path.GetExtension(file_path) != ".yaml")
            {
                Console.WriteLine("Alert: Invalid file format for Capterra, must be .yaml! If the data format has been changed, try updating the logic.");
                return;
            }

            Console.WriteLine($"Importing from Capterra: {file_path}");

        }

        private void Importsoftwareadvice(string file_path)
        {
            if (Path.GetExtension(file_path) != ".json")
            {
                Console.WriteLine("Alert: Invalid file format for Software Advice, must be .json! If the data format has been changed, try updating the logic.");
                return;
            }

            Console.WriteLine($"Importing from Capterra: {file_path}");

        }
    }
}
