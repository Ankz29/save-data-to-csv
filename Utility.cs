using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using ProductsCSV.Models;
using System.Configuration;
using Newtonsoft.Json;

namespace ProductsCSV
{
    public static class Utility
    {
        public static dynamic getProductsData(string url)
        {
            List<ProductList> modelData = new List<ProductList>();
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var resultant1 = reader.ReadLine();
                var results1 = JsonConvert.DeserializeObject<List<Products>>(resultant1);

                string productURL = ConfigurationManager.AppSettings["ProductBaseURL"].ToString();

                foreach (var item in results1)
                {
                    modelData.Add(new ProductList()
                    {
                        productCode = item.ProductCode,
                        parentURL = productURL + item.parent,

                    });
                }
            }
            catch (Exception ex)
            {

            }
            return modelData;
        }

        public static void storeInCSV(List<ProductList> dataToStore)
        {
            try
            {
                var file = ConfigurationManager.AppSettings["CSVPath"].ToString();

                using (var stream = System.IO.File.CreateText(file))
                {
                    stream.WriteLine("Goodman Products Model Number and Products URL");
                    foreach (var item1 in dataToStore)
                    {
                        string productCode = item1.productCode;
                        string parentURL = item1.parentURL;
                        string csvRow = string.Format("{0},{1}", "Product Model - " + productCode, Environment.NewLine + "Product URL - " + parentURL + System.Environment.NewLine);
                        stream.WriteLine(csvRow);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}