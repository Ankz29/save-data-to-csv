using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductsCSV.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Text;
using ProductsCSV.Models;
using System.Configuration;
using ProductsCSV;

namespace ProductsCSV.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /Products/
        public ActionResult Index()
        {
            string productsURL = ConfigurationManager.AppSettings["ProductAPI"].ToString();

            List<ProductList> productsData = Utility.getProductsData(productsURL);
            Utility.storeInCSV(productsData);

            return View();
        }

    }
}