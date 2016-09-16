/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.dao;

import com.guian.db.AccessDB;
import com.guian.entities.PlaceTour;
import com.guian.entities.Tour;
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
public class TourDAO {

    public void addTour(Tour objTour) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Tour WHERE TourID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objTour.getEnterpriseID());
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                throw new SQLException("El codigo del Tour ya existe");
            }

            query = new StringBuilder();
            query.append("INSERT INTO Tour(Name,Description,Star,Logo,Cost,EnterpriseID) VALUES(?,?,?,?,?,?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, objTour.getName());
            ps.setString(2, objTour.getDescription());
            ps.setInt(3, objTour.getStar());
            ps.setString(4, objTour.getLogo());
            ps.setBigDecimal(5, objTour.getCost());
            ps.setInt(6, objTour.getEnterpriseID());
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

    public void editTour(Tour objTour) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Tour SET Name = ?,Description = ?,Star=?,Logo = ?,Cost = ?,EnterpriseID=? WHERE TourID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objTour.getName());
            ps.setString(2, objTour.getDescription());
            ps.setInt(3, objTour.getStar());
            ps.setString(4, objTour.getLogo());
            ps.setBigDecimal(5, objTour.getCost());
            ps.setInt(6, objTour.getEnterpriseID());
            ps.setInt(7, objTour.getTourID());

            int realizado = ps.executeUpdate();
            if (realizado == 0) {
                throw new SQLException("Tour no existe!");
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

    public void deleteTour(Tour objTour) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("DELETE FROM Tour WHERE TourID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objTour.getTourID());
            int realizado = ps.executeUpdate();
            if (realizado == 0) {
                throw new SQLException("Tour no existe!");
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

    public List<Tour> getTours() {
        Connection cn = null;
        try {
            List<Tour> lstTours = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Tour");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Tour obj = new Tour();
                obj.setTourID(rs.getInt("TourID"));
                obj.setName(rs.getString("Name"));
                obj.setDescription(rs.getString("Description"));
                obj.setStar(rs.getInt("Star"));
                obj.setLogo(rs.getString("Logo"));
                obj.setCost(rs.getBigDecimal("Cost"));
                obj.setEnterpriseID(rs.getInt("EnterpriseID"));

                lstTours.add(obj);
            }
            return lstTours;
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
    
    public List<Tour> getToursByEnterprise(int EnterpriseID) {
        Connection cn = null;
        try {
            List<Tour> lstTours = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Tour");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, EnterpriseID);
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Tour obj = new Tour();
                obj.setTourID(rs.getInt("TourID"));
                obj.setName(rs.getString("Name"));
                obj.setDescription(rs.getString("Description"));
                obj.setStar(rs.getInt("Star"));
                obj.setLogo(rs.getString("Logo"));
                obj.setCost(rs.getBigDecimal("Cost"));
                obj.setEnterpriseID(rs.getInt("EnterpriseID"));

                lstTours.add(obj);
            }
            return lstTours;
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
    
    /*
    No se craera otra JavaClass para Place_Tour, se desarrollara en esta clase
    */
    
    public void addPlaceTour(PlaceTour objPlaceTour) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Place_Tour WHERE PlaceID = ? and TourID=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objPlaceTour.getPlaceID());
            ps.setInt(2, objPlaceTour.getTourID());
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                throw new SQLException("El codigo del Tour y Lugar ya existe");
            }

            query = new StringBuilder();
            query.append("INSERT INTO Place_Tour(PlaceID,TourID) VALUES(?,?)");
            ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objPlaceTour.getPlaceID());
            ps.setInt(2, objPlaceTour.getTourID());
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
}
