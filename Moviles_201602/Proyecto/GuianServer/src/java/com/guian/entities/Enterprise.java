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
    private String Email;
    private String Password;
    private String Name;
    private String Category;
    private int RUC;    
    private String Status;

    public int getEnterpriseID() {
        return EnterpriseID;
    }

    public void setEnterpriseID(int EnterpriseID) {
        this.EnterpriseID = EnterpriseID;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String Email) {
        this.Email = Email;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String Password) {
        this.Password = Password;
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

    public String getStatus() {
        return Status;
    }

    public void setStatus(String Status) {
        this.Status = Status;
    }
    
        
}
