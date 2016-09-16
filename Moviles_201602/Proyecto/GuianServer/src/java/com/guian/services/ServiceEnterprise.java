/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.services;

import com.guian.dao.EnterpriseDAO;
import com.guian.entities.Enterprise;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author David
 */
@WebService(serviceName = "ServiceEnterprise")
public class ServiceEnterprise {

    @WebMethod(operationName = "LoginAdmin")
    public Enterprise LoginEnterprise(Enterprise objEnterprise) {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        return objEnterpriseDAO.LoginEnterprise(objEnterprise);
    }
    
    @WebMethod(operationName = "addEnterprise")
    public void addEnterprise(Enterprise objEnterprise) {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        objEnterpriseDAO.addEnterprise(objEnterprise);
    }
    
    @WebMethod(operationName = "editEnterprise")
    public void editEnterprise(Enterprise objEnterprise) {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        objEnterpriseDAO.editEnterprise(objEnterprise);
    }
    
    @WebMethod(operationName = "deleteEnterprise")
    public void deleteEnterprise(Enterprise objEnterprise) {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        objEnterpriseDAO.deleteEnterprise(objEnterprise);
    }
    
    @WebMethod(operationName = "getEnterprises")
    public List<Enterprise> getEnterprises() {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        return objEnterpriseDAO.getEnterprises();
    }
    
    @WebMethod(operationName = "getEnterprisesByStatus")
    public List<Enterprise> getEnterprisesByStatus(String status) {

        EnterpriseDAO objEnterpriseDAO = new EnterpriseDAO();
        return objEnterpriseDAO.getEnterprisesByStatus(status);
    }
}
