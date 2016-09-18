using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServicePlace;
using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class LstPlacesByTourVM
    {
        private ServicePlaceClient ServicePlace;
        private ServiceTourClient ServiceTour;
        public List<place> lstPlaces;

        public List<place> getLstPlacesByTour(int TourID)
        {
            ServicePlace = new ServicePlaceClient();
            ServiceTour = new ServiceTourClient();
            lstPlaces = new List<place>();
            //xD triplefordonlusho
            foreach(place obj in ServicePlace.getPlaces().ToList())
            {
                foreach(placeTour obj2 in ServiceTour.getPlacesTour().ToList())
                {
                    if (obj.placeID == obj2.placeID && obj2.tourID==TourID) lstPlaces.Add(obj);
                }
            }
            return lstPlaces;            
        }
    }
}