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
        public ActionResult AddEditPlace(int? PlaceID)
        {
            try
            {
                AddEditPlaceVM objViewModel = new AddEditPlaceVM();
                if (PlaceID.HasValue)
                {
                    objViewModel.objPlace = objViewModel.getPlaceByID(PlaceID.Value);
                    //objViewModel.PlaceID = objViewModel.objPlace.placeID;
                }
                else objViewModel.objPlace = new ServicePlace.place();
                objViewModel.lstCities = objViewModel.getCities();
                objViewModel.select();
                return View("AddEditPlace", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult AddEditPlace(AddEditPlaceVM objViewModel)
        {
            try
            {
                if (objViewModel.objPlace.placeID > 0)
                {
                    objViewModel.EditPlace(objViewModel.objPlace);
                }
                else { objViewModel.objPlace.visits = 0; objViewModel.AddPlace(objViewModel.objPlace); }

                return RedirectToAction("LstPlaces");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult DeletePlace(int? PlaceID)
        {
            try
            {
                DeletePlaceVM objViewModel = new DeletePlaceVM();
                objViewModel.DeletePlace(PlaceID.Value);
                return RedirectToAction("LstPlaces");
            }
            catch (Exception)
            {
                throw;
            }
        }
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
        public ActionResult ActDesEnterprise(int enterpriseID, string status)
        {
            try
            {
                ActDesEnterpriseVM objViewModel = new ActDesEnterpriseVM();
                if (status == "PEN"||status=="DES") objViewModel.ActDesPlace(enterpriseID, "ACT");
                else objViewModel.ActDesPlace(enterpriseID, "DES");
                return RedirectToAction("LstEnterprises");
            }
            catch (Exception)
            {
                throw;
            }
        }
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