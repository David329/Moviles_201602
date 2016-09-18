using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class LstToursVM
    {
        public string Filtro { get; set; }
        private ServiceTourClient ServiceTour;

        public List<tour> lstTours { get; set; }
        private List<tour> lst { get; set; }
        public List<tour> getLstTours(int EnterpriseID)
        {
            ServiceTour = new ServiceTourClient();
            if (string.IsNullOrEmpty(Filtro)) return ServiceTour.getToursByEnterprise(EnterpriseID).ToList();
            else
            {
                lst = new List<tour>();
                lstTours = ServiceTour.getToursByEnterprise(EnterpriseID).ToList();
                foreach (tour obj in lstTours)
                {
                    if (obj.name.Contains(Filtro)) lst.Add(obj);
                }
                return lst;
            }
        }
    }
}