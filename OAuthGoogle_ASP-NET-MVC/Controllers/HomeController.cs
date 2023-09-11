using OAuthGoogle.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OAuthGoogle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthGoogle(string email)
        {
            return Redirect(GoogleApiHelper.GetOAuthUrl(email));
        }

        public ActionResult OAuthCallback(string code, string error, string state)
        {
            try
            {
                if (!string.IsNullOrEmpty(code))
                {
                    ViewBag.Message = "Successfull " + code;
                }
                if (!string.IsNullOrEmpty(error))
                {
                    ViewBag.Message = "Error " + error;
                }
                if (!string.IsNullOrEmpty(state))
                {
                    ViewBag.MailAddress = state;
                }
            }
            catch
            {

            }
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
    }
}