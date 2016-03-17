using DigitalMarket.Core.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DigitalMarket.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Session[Keys.UserLogin] = null;

            return View();
        }

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult GetCurrentUserLogin()
        {
            var login = Session[Keys.UserLogin];

            if (login == null)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Current user login is not found.");
            }

            return Json(login);
        }

        public ActionResult Login(string name, string password)
        {


            var login = Session[Keys.UserLogin];



            if (login == null)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Login or password is not correct.");
            }

            return Json(login);
        }
    }
}
