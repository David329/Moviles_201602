using System;
using System.Web.Mvc;
using GuianClient.ViewModel.EnterpriseVM;
namespace GuianClient.Controllers
{
    public class EnterpriseController : Controller
    {
        public ActionResult EntInicio()
        {
            return View();
        }
        public ActionResult LstTours()
        {
            try
            {
                LstToursVM objViewModel = new LstToursVM();
                objViewModel.lstTours = objViewModel.getLstTours();
                return View("LstTours", objViewModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult LstPlaces()
        {
            return View();
        }
        public ActionResult EntProfile()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}