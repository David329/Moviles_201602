using System;
using System.Web.Mvc;
using GuianClient.ViewModel.AdminVM;

namespace GuianClient.Controllers
{
    public class AdminController : Controller
    {
        //X EL MOMENTO LANZAREMOS LAS EXCEPCIONES CON THROW
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

        #region Places
        public ActionResult LstPlaces()
        {
            try
            {
                LstPlacesVM objViewModel = new LstPlacesVM();
                objViewModel.lstPlaces = objViewModel.GetLstPlaces();
                return View("LstPlaces", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult LstPlaces(LstPlacesVM objViewModel)
        {
            try
            {
                objViewModel.lstPlaces = objViewModel.GetLstPlaces();
                return View("LstPlaces", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Enterprises
        public ActionResult LstEnterprises()
        {
            try
            {
                LstEnterprisesVM objViewModel = new LstEnterprisesVM();
                objViewModel.lstEnterprises = objViewModel.GetLstEnterprises();
                return View("LstEnterprises", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult LstEnterprises(LstEnterprisesVM objViewModel)
        {
            try
            {
                objViewModel.lstEnterprises = objViewModel.GetLstEnterprises();
                return View("LstEnterprises", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}