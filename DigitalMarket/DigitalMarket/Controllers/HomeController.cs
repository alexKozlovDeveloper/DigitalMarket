using DigitalMarket.Core.Configurations;
using DigitalMarket.Db.Repositoryes;
using DigitalMarket.Shared.Logging;
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

        private const string connectionName = "DmConnection";

        public ActionResult Index()
        {
            //Session[Keys.UserLogin] = null;

            //DmRepository rep = new DmRepository("DmConnection");

            //rep.CreateUser("alex", "123!", DateTime.Now, "abd@gmail.com");



            //var logger = new DmLogger();
            var guid = Guid.NewGuid();
            var str = "Some message        12333333333333333331231545151515555515115" + guid.ToString();

            //Some message        1233333333333333333123154515151555551511531828e65-a861-456c-bb4e-8992a6a1706c

            DmLogger.Log.Info(str);


            return View();
        }

        public ActionResult RegistrationPage()
        {
            return View();
        }


        public ActionResult RegistrationNewUser(string name, string password, string dayOfBirth, string email)
        {
            DmRepository rep = new DmRepository(connectionName);

            DateTime day = DateTime.Parse(dayOfBirth);


            var sd = rep.Gets(a => a.Name == name);


            //rep.CreateUser(name, password, dayOfBirth, email);



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
