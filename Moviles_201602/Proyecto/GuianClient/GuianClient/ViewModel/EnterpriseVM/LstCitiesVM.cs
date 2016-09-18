using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceCity;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class LstCitiesVM
    {
        private ServiceCityClient ServiceCity;

        public List<city> lstCities;
        public int TourID;

        public List<city> getLstCities()
        {
            ServiceCity = new ServiceCityClient();
            return ServiceCity.getCities().ToList();
        }
    }
}