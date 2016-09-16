/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.services;

import com.guian.dao.AdminDAO;
import com.guian.entities.Admin;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author David
 */
@WebService(serviceName = "ServiceAdmin")
public class ServiceAdmin {

    @WebMethod(operationName = "LoginAdmin")
    public Admin LoginAdmin(Admin objAdmin) {

        AdminDAO objAdminDAO = new AdminDAO();
        return objAdminDAO.LoginAdmin(objAdmin);
    }
}
