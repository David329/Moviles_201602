using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceEnterprise;
namespace GuianClient.ViewModel.AdminVM
{
    public class ActDesEnterpriseVM
    {
        private ServiceEnterpriseClient ServiceEnterprise;
        public void ActDesPlace(int EnterpriseID,string status)
        {
            ServiceEnterprise = new ServiceEnterpriseClient();
            enterprise obj = ServiceEnterprise.getEnterpriseByID(EnterpriseID);
            obj.status = status;
            ServiceEnterprise.editEnterprise(obj);
        }
    }
}