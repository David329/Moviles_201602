using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuianClient.ServiceAdmin;
using GuianClient.ServiceEnterprise;
namespace GuianClient.ViewModel
{
    public class LoginViewModel
    {
        private ServiceEnterpriseClient serviceEN;
        private ServiceAdminClient serviceAD;

        public enterprise ObjEnterprise { get; set; }

        public void AddEnterprise(enterprise obj)
        {
            serviceEN = new ServiceEnterpriseClient();
            serviceEN.addEnterprise(obj);
        }
        public enterprise LoginEnterprise(enterprise obj)
        {
            serviceEN = new ServiceEnterpriseClient();
            obj = serviceEN.LoginEnterprise(obj);
            return obj;
        }
        public admin LoginAdmin(enterprise obj)
        {
            //Creamos un objeto Admin, xq como parametro esta enterprise y es xq en un login quiero q detecte cualquiera de los 2
            admin ObjAdmin = new admin();
            ObjAdmin.email = obj.email;
            ObjAdmin.password = obj.password;

            serviceAD = new ServiceAdminClient();
            ObjAdmin = serviceAD.LoginAdmin(ObjAdmin);
            return ObjAdmin;
        }
    }
}