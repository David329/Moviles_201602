using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class AddEditTourVM
    {
        private ServiceTourClient ServiceTour;
        public tour objTour{ get; set; }
        public void AddTour(tour obj)
        {
            ServiceTour = new ServiceTourClient();
            obj.costSpecified = true;
            ServiceTour.addTour(obj);
        }
        public void EditTour(tour obj)
        {
            ServiceTour = new ServiceTourClient();
            ServiceTour.editTour(obj);
        }
        public tour getTourByID(int TourID)
        {
            ServiceTour = new ServiceTourClient();
            return ServiceTour.getTourByID(TourID);
        }
    }
}