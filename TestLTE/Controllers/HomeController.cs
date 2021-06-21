using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestLTE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult About()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string Password)
        {

            if (userName == "L" && Password == "livi")
            {
                Session["UserName"] = userName;
                return View("About");
            }
            else
            {
                ViewBag.Message = "Please enter valid Email ID and Password";
                return View("Login");
            }
        }


        [HttpPost]
        public ActionResult Insert(string userName, string Password)
        {
            ViewBag.Message = "User Name " + userName + " Inserted ";

            return View("Contact");
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}