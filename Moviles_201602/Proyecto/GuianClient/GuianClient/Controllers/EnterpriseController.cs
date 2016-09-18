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
        #endregion
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