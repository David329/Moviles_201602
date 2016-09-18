using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServicePlace;
using GuianClient.ServiceCity;
using System.Web.Mvc;

namespace GuianClient.ViewModel.AdminVM
{
    public class AddEditPlaceVM
    {
        private ServiceCityClient ServiceCity;
        private ServicePlaceClient ServicePlace;

        public place objPlace { get; set; }
        //public int PlaceID { get; set; }//Este ID es solo para tener encuenta el objeto q se cambiara
        public List<city> lstCities { get; set; }
        public IEnumerable<SelectListItem> selectCities { get; set; }

        public void AddPlace(place obj)
        {
            ServicePlace = new ServicePlaceClient();
            ServicePlace.addPlace(obj);
        }
        public void EditPlace(place obj)
        {
            ServicePlace = new ServicePlaceClient();
            ServicePlace.editPlace(obj);
        }
        public place getPlaceByID(int PlaceID)
        {
            ServicePlace = new ServicePlaceClient();
            return ServicePlace.getPlaceByID(PlaceID);
        }
        public List<city> getCities()
        {
            ServiceCity = new ServiceCityClient();
            return ServiceCity.getCities().ToList();
        }
        public void select()
        {
            selectCities = from c in lstCities
                           select new SelectListItem
                           {
                               Text = c.country + " " + c.name,
                               Value = c.cityID.ToString()
                           };
        }
    }
}