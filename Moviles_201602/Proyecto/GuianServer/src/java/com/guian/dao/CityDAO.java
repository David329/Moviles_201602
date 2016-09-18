/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.dao;

import com.guian.db.AccessDB;
import com.guian.entities.City;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author David
 */
public class CityDAO {
    public List<City> getCities() {
        Connection cn = null;
        try {
            List<City> lstCities = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM City");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                City obj = new City();
                obj.setCityID(rs.getInt("CityID"));
                obj.setName(rs.getString("Name"));
                obj.setCountry(rs.getString("Country"));

                lstCities.add(obj);
            }
            return lstCities;
        } catch (SQLException ex) {
            throw new RuntimeException(ex.getMessage());
        } catch (Exception e) {
            throw new RuntimeException("No se tiene acceso al servidor");
        } finally {
            try {
                if (cn != null) {
                    cn.close();
                }
            } catch (Exception ex) {
            }
        }
    }
    
    public List<City> getCitiesByCountry(String Country) {
        Connection cn = null;
        try {
            List<City> lstCities = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM City WHERE Country=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, Country);
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                City obj = new City();
                obj.setCityID(rs.getInt("CityID"));
                obj.setName(rs.getString("Name"));
                obj.setCountry(rs.getString("Country"));

                lstCities.add(obj);
            }
            return lstCities;
        } catch (SQLException ex) {
            throw new RuntimeException(ex.getMessage());
        } catch (Exception e) {
            throw new RuntimeException("No se tiene acceso al servidor");
        } finally {
            try {
                if (cn != null) {
                    cn.close();
                }
            } catch (Exception ex) {
            }
        }
    }
}
