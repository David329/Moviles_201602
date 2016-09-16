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
public class Place {
    private int PlaceID;
    private String Name;
    private String Audio;
    private String Longitud;
    private String Latitud;
    private String Description;
    private int Visits;
    private int CityID;

    public int getPlaceID() {
        return PlaceID;
    }

    public void setPlaceID(int PlaceID) {
        this.PlaceID = PlaceID;
    }

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public String getAudio() {
        return Audio;
    }

    public void setAudio(String Audio) {
        this.Audio = Audio;
    }

    public String getLongitud() {
        return Longitud;
    }

    public void setLongitud(String Longitud) {
        this.Longitud = Longitud;
    }

    public String getLatitud() {
        return Latitud;
    }

    public void setLatitud(String Latitud) {
        this.Latitud = Latitud;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String Description) {
        this.Description = Description;
    }

    public int getVisits() {
        return Visits;
    }

    public void setVisits(int Visits) {
        this.Visits = Visits;
    }

    public int getCityID() {
        return CityID;
    }

    public void setCityID(int CityID) {
        this.CityID = CityID;
    }
    
    
}
