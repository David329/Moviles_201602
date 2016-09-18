/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.services;

import com.guian.dao.PlaceDAO;
import com.guian.entities.Place;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author David
 */
@WebService(serviceName = "ServicePlace")
public class ServicePlace {
    
    @WebMethod(operationName = "addPlace")
    public void addPlace(Place objPlace) {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        objPlaceDAO.addPlace(objPlace);
    }
    
    @WebMethod(operationName = "editPlace")
    public void editPlace(Place objPlace) {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        objPlaceDAO.editPlace(objPlace);
    }
    
    @WebMethod(operationName = "deletePlace")
    public void deletePlace(Place objPlace) {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        objPlaceDAO.deletePlace(objPlace);
    }
    
    @WebMethod(operationName = "getPlaces")
    public List<Place> getPlaces() {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        return objPlaceDAO.getPlaces();
    }
    
    @WebMethod(operationName = "getPlacesByCity")
    public List<Place> getPlacesByCity(int CityID) {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        return objPlaceDAO.getPlacesByCity(CityID);
    }
    
    @WebMethod(operationName = "getPlaceByID")
    public Place getPlaceByID(int PlaceID) {
        
        PlaceDAO objPlaceDAO = new PlaceDAO();
        return objPlaceDAO.getPlaceByID(PlaceID);
    }
}
