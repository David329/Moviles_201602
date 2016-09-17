using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuianClient.ViewModel;

namespace GuianClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return RedirectToAction("index.html");
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEnterprise(LoginViewModel ObjViewModel)
        {
            try
            {
                ObjViewModel.AddEnterprise(ObjViewModel.ObjEnterprise);
                return RedirectToAction("Login", "Home");
            }
            catch (Exception)
            {
                return RedirectToAction("Login", "Home");
            }
        }
    }
}