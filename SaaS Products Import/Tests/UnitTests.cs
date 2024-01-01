using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace SaaS_Products_Import.Tests
{
    [TestFixture]
    public class UnitTests
    {
        static string GetSolutionFolder()
        {
            string current = Directory.GetCurrentDirectory();
            while (!Directory.GetFiles(current, "*.sln").Any())
            {
                current = Directory.GetParent(current).FullName;
            }
            return current;
        }

        //Requirement 5: Unit Tests

        string solutionfolder = GetSolutionFolder();

        private string valid_capterra = Path.Combine(solutionfolder, "Files", "capterra.yaml");
        private string valid_software_advice = Path.Combine(solutionfolder,  "Files", "softwareadvice.json");


        [Test]

        public void Import_Capterra_Yaml_Success()
        {
            ProductsImporter productsImporter = new ProductsImporter();
            Storage storage = new Storage();

            productsImporter.Process("capterra", valid_capterra);
            List<string> Data = storage.GetStoredData();

            Assert.That(Data, Is.Not.Empty);
            Assert.That(Data, Contains.Item("Capterra Data Processed!"));

        }


        [Test]

        public void Import_SA_Json_Success()
        {
            ProductsImporter productsImporter = new ProductsImporter();
            Storage storage = new Storage();

            productsImporter.Process("capterra", valid_software_advice);
            List<string> Data = storage.GetStoredData();

            Assert.That(Data, Is.Not.Empty);
            Assert.That(Data, Contains.Item("Software Advice Data Processed!"));

        }
        

    }
}
