using Lab_11._3_Coffee_Shop_Registration_Continued.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_11._2_Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to GC Coffee";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(string firstname, string lastname, string gender, string birthday, string email, string username, string password )
        {
            WebUser user = new WebUser()
            {
                Firstname = firstname,
                Lastname = lastname,
                Gender = gender,
                Birthday = birthday,
                Email = email,
                Username = username,
                Password = password
            };
            //ViewBag.Welcome = $"Welcome, {firstname} {lastname}!";

            return View(user);
        }

    }
}