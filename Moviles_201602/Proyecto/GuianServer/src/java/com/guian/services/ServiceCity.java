/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.services;

import com.guian.dao.CityDAO;
import com.guian.entities.City;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author David
 */
@WebService(serviceName = "ServiceCity")
public class ServiceCity {

    @WebMethod(operationName = "getCities")
    public List<City> getCities() {
        
        CityDAO objCityDAO = new CityDAO();
        return objCityDAO.getCities();
    }
    
    @WebMethod(operationName = "getCitiesByCountry")
    public List<City> getCitiesByCountry(String Country) {
        
        CityDAO objCityDAO = new CityDAO();
        return objCityDAO.getCitiesByCountry(Country);
    }
}
