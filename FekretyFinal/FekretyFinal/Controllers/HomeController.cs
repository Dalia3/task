using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;


namespace FekretyFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult REGISTER()
        {
            return View();
        }

        public ActionResult ITEMS()  // method to read and display Jsonplaceholder data
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/todos");
            var objJson = JsonConvert.DeserializeObject<List<Models.JsonModel.RootObject>>(json);
            //here we will return this model to view
            return View(objJson); 
        }
        public ActionResult FEEDBACK()
        {
            return View();
        }

        
       // Note : code of edit and delete from jsonplaceholder file actually work on the data on site

        public ActionResult EditJsonPlaceHolderData() // update data in json file 
        {
        //    fetch('https://jsonplaceholder.typicode.com/posts/1', {
        //    method: 'PUT',
        //    body: JSON.stringify({
        //    id: 1,
        //    title: 'foo',
        //    body: 'bar',
        //    userId: 1
        //    }),
        //    headers: {
        //      "Content-type": "application/json; charset=UTF-8"
        //    }
        //  })
        //  .then(response => response.json())
        //  .then(json => console.log(json))
            return RedirectToAction("Index");
        }



        public ActionResult DeleteJsonPlaceHolderData() // Delete data in json file 
        {
        //     fetch('https://jsonplaceholder.typicode.com/posts/1', {
        //      method: 'DELETE'
        //    })
         return RedirectToAction("Index");
        }
    }
}