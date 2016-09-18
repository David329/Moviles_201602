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
        #region Tour
        public ActionResult AddEditTour(int? TourID)
        {
            try
            {
                AddEditTourVM objViewModel = new AddEditTourVM();
                if (TourID.HasValue)
                {
                    objViewModel.objTour = objViewModel.getTourByID(TourID.Value);
                    //objViewModel.PlaceID = objViewModel.objPlace.placeID;
                }
                else objViewModel.objTour = new ServiceTour.tour();
                return View("AddEditTour", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult AddEditTour(AddEditTourVM objViewModel)
        {
            try
            {
                if (objViewModel.objTour.tourID > 0)
                {
                    objViewModel.EditTour(objViewModel.objTour);
                }
                else
                {
                    objViewModel.objTour.star = 0;
                    objViewModel.objTour.enterpriseID = ((ServiceEnterprise.enterprise)Session["objEnterprise"]).enterpriseID;
                    objViewModel.AddTour(objViewModel.objTour);
                }
                return RedirectToAction("LstTours");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult DeleteTour(int? TourID)
        {
            try
            {
                DeleteTourVM objViewModel = new DeleteTourVM();
                objViewModel.DeleteTour(TourID.Value);
                return RedirectToAction("LstTours");
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public ActionResult LstTours()
        {
            try
            {
                LstToursVM objViewModel = new LstToursVM();
                int EnterpriseID = ((ServiceEnterprise.enterprise)Session["objEnterprise"]).enterpriseID;
                objViewModel.lstTours = objViewModel.getLstTours(EnterpriseID);
                return View("LstTours", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult LstTours(LstToursVM objViewModel)
        {
            try
            {
                int EnterpriseID = ((ServiceEnterprise.enterprise)Session["objEnterprise"]).enterpriseID;
                objViewModel.lstTours = objViewModel.getLstTours(EnterpriseID);
                return View("LstTours", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult LstLugTours()
        {
            try
            {
                LstToursVM objViewModel = new LstToursVM();
                int EnterpriseID = ((ServiceEnterprise.enterprise)Session["objEnterprise"]).enterpriseID;
                objViewModel.lstTours = objViewModel.getLstTours(EnterpriseID);
                return View("LstLugTours", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult LstPlacesByTour(int? TourID)
        {
            try
            {
                LstPlacesByTourVM objViewModel = new LstPlacesByTourVM();
                objViewModel.lstPlaces = objViewModel.getLstPlacesByTour(TourID.Value);
                return View("LstPlacesByTour", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        public ActionResult LstCities(int? TourID)
        {
            try
            {
                LstCitiesVM objViewModel = new LstCitiesVM();
                objViewModel.lstCities = objViewModel.getLstCities();
                objViewModel.TourID = TourID.Value;
                return View("LstCities", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult LstPlaces(int? CityID,int? TourID)
        {
            try
            {
                LstPlacesVM objViewModel = new LstPlacesVM();
                objViewModel.lstPlaces = objViewModel.getLstPlaces(CityID.Value);
                objViewModel.TourID = TourID.Value;
                return View("LstPlaces", objViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult AddPlaceTour(int? PlaceID, int? TourID)
        {
            try
            {
                AddPlaceTourVM objViewModel = new AddPlaceTourVM();
                objViewModel.AddPlaceTour(PlaceID.Value,TourID.Value);
                return RedirectToAction("LstTours");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult EntProfile()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}