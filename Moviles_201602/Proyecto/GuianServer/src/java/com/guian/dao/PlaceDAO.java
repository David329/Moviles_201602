/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.dao;

import com.guian.db.AccessDB;
import com.guian.entities.Place;
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
public class PlaceDAO {
    
    public void addPlace(Place objPlace) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Place WHERE PlaceID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objPlace.getPlaceID());
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                throw new SQLException("El codigo del lugar ya existe");
            }

            query = new StringBuilder();
            query.append("INSERT INTO Place(Name,Audio,Longitud,Latitud,Description,Visits,CityID) VALUES(?,?,?,?,?,?,?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, objPlace.getName());
            ps.setString(2, objPlace.getAudio());
            ps.setString(3, objPlace.getLongitud());
            ps.setString(4, objPlace.getLatitud());
            ps.setString(5, objPlace.getDescription());
            ps.setInt(6, objPlace.getVisits());
            ps.setInt(7, objPlace.getCityID());
            ps.executeUpdate();
            cn.commit();

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
    
    public void editPlace(Place objPlace) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Place SET Name = ?,Audio = ?,Longitud=?,Latitud = ?,Description = ?,Visits=?,CityID=? WHERE PlaceID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objPlace.getName());
            ps.setString(2, objPlace.getAudio());
            ps.setString(3, objPlace.getLongitud());
            ps.setString(4, objPlace.getLatitud());
            ps.setString(5, objPlace.getDescription());
            ps.setInt(6, objPlace.getVisits());
            ps.setInt(7, objPlace.getCityID());
            ps.setInt(8, objPlace.getPlaceID());

            int realizado = ps.executeUpdate();
            if (realizado == 0) {
                throw new SQLException("producto no existe!");
            }
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
    
    public void deletePlace(Place objPlace) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("DELETE FROM Place WHERE PlaceID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objPlace.getPlaceID());
            int realizado = ps.executeUpdate();
            if (realizado == 0) {
                throw new SQLException("Lugar no existe!");
            }
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
    
    public List<Place> getPlaces() {
        Connection cn = null;
        try {
            List<Place> lstPlaces = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Place");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Place obj = new Place();
                obj.setPlaceID(rs.getInt("PlaceID"));
                obj.setName(rs.getString("Name"));
                obj.setAudio(rs.getString("Audio"));
                obj.setLongitud(rs.getString("Longitud"));
                obj.setLatitud(rs.getString("Latitud"));
                obj.setDescription(rs.getString("Description"));
                obj.setVisits(rs.getInt("Visits"));
                obj.setCityID(rs.getInt("CityID"));

                lstPlaces.add(obj);
            }
            return lstPlaces;
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
    
    public List<Place> getPlacesByCity(int CityID) {
        Connection cn = null;
        try {
            List<Place> lstPlaces = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Place WHERE CityID=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, CityID);
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Place obj = new Place();
                obj.setPlaceID(rs.getInt("PlaceID"));
                obj.setName(rs.getString("Name"));
                obj.setAudio(rs.getString("Audio"));
                obj.setLongitud(rs.getString("Longitud"));
                obj.setLatitud(rs.getString("Latitud"));
                obj.setDescription(rs.getString("Description"));
                obj.setVisits(rs.getInt("Visits"));
                obj.setCityID(rs.getInt("CityID"));

                lstPlaces.add(obj);
            }
            return lstPlaces;
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
