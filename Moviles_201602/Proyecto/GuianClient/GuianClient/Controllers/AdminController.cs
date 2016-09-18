using System;
using System.Web.Mvc;
using GuianClient.ViewModel;

namespace GuianClient.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult LstEnterprises()
        {
            return View();
        }
        public ActionResult LstPlaces()
        {
            LstClienteViewModel objViewModel = new LstClienteViewModel();
            objViewModel.lstCliente = objViewModel.GetLstCliente();
            return View("LstClientes", "_AdministradorLayout", objViewModel);
            //return View();
        }
        public ActionResult AdmInicio()
        {
            return View();
        }
        public ActionResult AdmProfile()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}