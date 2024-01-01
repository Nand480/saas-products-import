using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System;
using System.IO;

namespace SaaS_Products_Import
{
    class Program
    {
        //Requirement 1: we are not taking any user inputs and have put file paths as of now
        //Requirement 2: We are keeping both the files in our project
        static void Main()
        {
            string solutionfolder = GetSolutionFolder();

            ProviderFileDetails capterradetails = new ProviderFileDetails
            {
                provider = "capterra",
                file_path = Path.Combine(solutionfolder, "Files", "capterra.yaml")

            };

            ProviderFileDetails sadetails = new ProviderFileDetails
            {
                provider = "softwareadvice",
                file_path = Path.Combine(solutionfolder,  "Files", "softwareadvice.json")
            };

            ProductsImporter productsImporter = new ProductsImporter();
            productsImporter.Process(capterradetails.provider, capterradetails.file_path);
            productsImporter.Process(sadetails.provider, sadetails.file_path);

            DisplayFile(capterradetails);
            DisplayFile(sadetails);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static string GetSolutionFolder()
        {
            string current = Directory.GetCurrentDirectory();
            while (!Directory.GetFiles(current, "*.sln").Any())
            {
                current = Directory.GetParent(current).FullName;
            }
            return current;
        }


        static void DisplayFile (ProviderFileDetails details)
        {
            Console.WriteLine($"Provider: {details.provider}");
            Console.WriteLine($"File Path: {details.file_path}");
            try
            {
                if(File.Exists(details.file_path))
                {
                    string filedata = File.ReadAllText(details.file_path);
                    Console.WriteLine(filedata);
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed!");
            }
        }

        class ProviderFileDetails
        {
            public string provider { get; set; }
            public string file_path { get; set; }
        }
    }
}
