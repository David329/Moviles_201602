using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuianClient.ViewModel
{
    public class LoginViewModel
    {
        private ServiceEnterprise.ServiceEnterpriseClient service;

        public ServiceEnterprise.enterprise ObjEnterprise { get; set; }

        public void AddEnterprise(ServiceEnterprise.enterprise obj)
        {
            service = new ServiceEnterprise.ServiceEnterpriseClient();
            service.addEnterprise(obj);
        }
    }
}