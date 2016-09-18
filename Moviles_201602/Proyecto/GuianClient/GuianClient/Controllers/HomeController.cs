using System;
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
        public ActionResult Login(LoginViewModel ObjViewModel)
        {
            try
            {
                var objEnterprise = ObjViewModel.LoginEnterprise(ObjViewModel.ObjEnterprise);
                var objAdmin = ObjViewModel.LoginAdmin(ObjViewModel.ObjEnterprise);
                if (objEnterprise != null)
                {
                    Session["objEnterprise"] = objEnterprise; return RedirectToAction("EntInicio", "Enterprise");
                }
                else if (objAdmin != null)
                {
                    Session["objAdmin"] = objAdmin; return RedirectToAction("AdmInicio", "Admin");
                }
                return RedirectToAction("Login", "Home");
            }
            catch (Exception)
            {
                return RedirectToAction("Login", "Home");
            }
        }
        [HttpPost]
        public ActionResult AddEnterprise(LoginViewModel ObjViewModel)
        {
            try
            {
                ObjViewModel.ObjEnterprise.status = "PEN";
                ObjViewModel.AddEnterprise(ObjViewModel.ObjEnterprise);
                return RedirectToAction("Login", "Home");
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return RedirectToAction("Login", "Home");
            }
        }
    }
}