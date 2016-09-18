using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class AddPlaceTourVM
    {
        private ServiceTourClient ServiceTour;
        public void AddPlaceTour(int PlaceID,int TourID)
        {
            ServiceTour = new ServiceTourClient();

            placeTour obj = new placeTour();
            obj.placeID = PlaceID;
            obj.tourID=TourID;

            ServiceTour.addPlaceTour(obj);
        }
    }
}