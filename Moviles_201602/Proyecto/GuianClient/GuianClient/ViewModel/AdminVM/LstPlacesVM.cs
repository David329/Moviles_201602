using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServicePlace;
using GuianClient.ServiceCity;
namespace GuianClient.ViewModel.AdminVM
{
    public class LstPlacesVM
    {
        public string Filtro { get; set; }
        public List<place> lstPlaces { get; set; }
        private ServicePlaceClient ServicePlace;
        private ServiceCityClient ServiceCity;

        public List<place> GetLstPlaces()
        {
            if (string.IsNullOrEmpty(Filtro)) return ServicePlace.getPlaces().ToList();
            else
            {
                List<city> lstCities = ServiceCity.getCities().ToList();
                foreach (city obj in lstCities)
                {
                    if (obj.name == Filtro) return ServicePlace.getPlacesByCity(obj.cityID).ToList();
                }
            }
            return null;
        }
    }
}