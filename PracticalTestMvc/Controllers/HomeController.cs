using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracticalTest.Models;

namespace PracticalTestMvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(newsArticles)
        {
            // send this data to UI and iterate it on the view page with minimum styling, just separate new articles from each other. NOT FANCY UI DESIGN NEEDED AT THIS MOMENT
            var newsArticles = GetArticles();
            return View();
        }
        protected object GetArticles()
        {
            // write the url here from document and PASS it's API KEY
            string url = "follow the .pdf file";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            String jsonResponse = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                jsonResponse = reader.ReadToEnd();
reader.Close();
dataStream.Close();
}
            return JsonConvert.DeserializeObject<XYZ>(jsonResponse);
        }
    }
}