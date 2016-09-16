/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.entities;

import java.math.BigDecimal;

/**
 *
 * @author David
 */
public class Tour {
    private int TourID;
    private String Name;
    private String Description;
    private int Star;
    private String Logo;
    private BigDecimal Cost;
    private int EnterpriseID;

    public int getTourID() {
        return TourID;
    }

    public void setTourID(int TourID) {
        this.TourID = TourID;
    }

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String Description) {
        this.Description = Description;
    }

    public int getStar() {
        return Star;
    }

    public void setStar(int Star) {
        this.Star = Star;
    }

    public String getLogo() {
        return Logo;
    }

    public void setLogo(String Logo) {
        this.Logo = Logo;
    }

    public BigDecimal getCost() {
        return Cost;
    }

    public void setCost(BigDecimal Cost) {
        this.Cost = Cost;
    }

    public int getEnterpriseID() {
        return EnterpriseID;
    }

    public void setEnterpriseID(int EnterpriseID) {
        this.EnterpriseID = EnterpriseID;
    }
    
}
