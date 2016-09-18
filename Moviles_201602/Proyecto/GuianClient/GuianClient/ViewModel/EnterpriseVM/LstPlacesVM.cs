using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServicePlace;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class LstPlacesVM
    {
        private ServicePlaceClient ServicePlace;

        public List<place> lstPlaces;
        public int TourID;
        public List<place> getLstPlaces(int CityID)
        {
            ServicePlace = new ServicePlaceClient();
            return ServicePlace.getPlacesByCity(CityID).ToList();
        }
    }
}