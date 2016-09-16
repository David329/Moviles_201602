/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.entities;

/**
 *
 * @author David
 */
public class Enterprise {
    private int EnterpriseID;
    private String Name;
    private String Category;
    private int RUC;

    public int getEnterpriseID() {
        return EnterpriseID;
    }

    public void setEnterpriseID(int EnterpriseID) {
        this.EnterpriseID = EnterpriseID;
    }

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public String getCategory() {
        return Category;
    }

    public void setCategory(String Category) {
        this.Category = Category;
    }

    public int getRUC() {
        return RUC;
    }

    public void setRUC(int RUC) {
        this.RUC = RUC;
    }
    
}
