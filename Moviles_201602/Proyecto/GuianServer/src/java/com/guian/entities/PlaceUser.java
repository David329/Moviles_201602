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
public class PlaceUser {
    private int PlaceID;
    private int UserID;
    private boolean Interest;

    public int getPlaceID() {
        return PlaceID;
    }

    public void setPlaceID(int PlaceID) {
        this.PlaceID = PlaceID;
    }

    public int getUserID() {
        return UserID;
    }

    public void setUserID(int UserID) {
        this.UserID = UserID;
    }

    public boolean isInterest() {
        return Interest;
    }

    public void setInterest(boolean Interest) {
        this.Interest = Interest;
    }
    
    
}
