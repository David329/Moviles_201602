using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceEnterprise;
namespace GuianClient.ViewModel.AdminVM
{
    public class LstEnterprisesVM
    {
        public string Filtro { get; set; }
        public List<enterprise> lstEnterprises { get; set; }
        private ServiceEnterpriseClient ServiceEnterprise;

        public List<enterprise> GetLstEnterprises()
        {
            ServiceEnterprise = new ServiceEnterpriseClient();
            if (string.IsNullOrEmpty(Filtro)) return ServiceEnterprise.getEnterprises().ToList();
            else return ServiceEnterprise.getEnterprisesByStatus(Filtro).ToList();
        }
    }
}