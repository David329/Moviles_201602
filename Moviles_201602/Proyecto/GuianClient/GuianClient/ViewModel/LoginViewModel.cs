using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuianClient.ViewModel
{
    public class LoginViewModel
    {
        private ServiceEnterprise.ServiceEnterpriseClient serviceEN;
        private ServiceAdmin.ServiceAdminClient serviceAD;

        public ServiceEnterprise.enterprise ObjEnterprise { get; set; }

        public void AddEnterprise(ServiceEnterprise.enterprise obj)
        {
            serviceEN = new ServiceEnterprise.ServiceEnterpriseClient();
            serviceEN.addEnterprise(obj);
        }
        public ServiceEnterprise.enterprise LoginEnterprise(ServiceEnterprise.enterprise obj)
        {
            serviceEN = new ServiceEnterprise.ServiceEnterpriseClient();
            obj = serviceEN.LoginEnterprise(obj);
            return obj;
        }
        public ServiceAdmin.admin LoginAdmin(ServiceEnterprise.enterprise obj)
        {
            //Creamos un objeto Admin, xq como parametro esta enterprise y es xq en un login quiero q detecte cualquiera de los 2
            ServiceAdmin.admin ObjAdmin = new ServiceAdmin.admin();
            ObjAdmin.email = obj.email;
            ObjAdmin.password = obj.password;

            serviceAD = new ServiceAdmin.ServiceAdminClient();
            ObjAdmin = serviceAD.LoginAdmin(ObjAdmin);
            return ObjAdmin;
        }
    }
}