using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Ryan";
            user.LastName = "OMar";
            user.Age = 34;
            return View(user);




            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

           // return RedirectToAction("Contact");
           // return Content("Hello");



            //Random rnd = new Random(10);
            //var num = rnd.Next();
            //if (num > 20000)
            //    return View("About");

            
            //ViewBag.RandomNumber = num;


            //Logging into text file
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Miste\OneDrive\Documents\GitHub\C#\C#Projects\MvcTutorial\Logs\log.txt", text);
           //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}