using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class LstToursVM
    {
        private ServiceTourClient ServiceTour;

        public List<tour> lstTours { get; set; }
        public List<tour> getLstTours()
        {
            ServiceTour = new ServiceTourClient();
            return ServiceTour.getTours().ToList();
        }
    }
}