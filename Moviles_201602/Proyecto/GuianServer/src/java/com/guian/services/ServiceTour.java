/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.services;

import com.guian.dao.TourDAO;
import com.guian.entities.PlaceTour;
import com.guian.entities.Tour;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author David
 */
@WebService(serviceName = "ServiceTour")
public class ServiceTour {

    @WebMethod(operationName = "addTour")
    public void addTour(Tour objTour) {

        TourDAO objTourDAO = new TourDAO();
        objTourDAO.addTour(objTour);
    }
    
    @WebMethod(operationName = "editTour")
    public void editTour(Tour objTour) {

        TourDAO objTourDAO = new TourDAO();
        objTourDAO.editTour(objTour);
    }
    
    @WebMethod(operationName = "deleteTour")
    public void deleteTour(Tour objTour) {

        TourDAO objTourDAO = new TourDAO();
        objTourDAO.deleteTour(objTour);
    }
    
    @WebMethod(operationName = "getTours")
    public List<Tour> getTours() {

        TourDAO objTourDAO = new TourDAO();
        return objTourDAO.getTours();
    }
    
    @WebMethod(operationName = "getToursByEnterprise")
    public List<Tour> getToursByEnterprise(int EnterpriseID) {

        TourDAO objTourDAO = new TourDAO();
        return objTourDAO.getToursByEnterprise(EnterpriseID);
    }
    
    @WebMethod(operationName = "getTourByID")
    public Tour getTourByID(int TourID) {

        TourDAO objTourDAO = new TourDAO();
        return objTourDAO.getTourByID(TourID);
    }
    
    //PLACETOUR
    
    @WebMethod(operationName = "addPlaceTour")
    public void addPlaceTour(PlaceTour objPlaceTour) {

        TourDAO objTourDAO = new TourDAO();
        objTourDAO.addPlaceTour(objPlaceTour);
    }
    
    @WebMethod(operationName = "getPlacesTour")
    public List<PlaceTour> getPlacesTour() {

        TourDAO objTourDAO = new TourDAO();
        return objTourDAO.getPlacesTour();
    }
}
