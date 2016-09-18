/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.dao;

import com.guian.db.AccessDB;
import com.guian.entities.Enterprise;
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
public class EnterpriseDAO {

    public Enterprise LoginEnterprise(Enterprise objEnterprise) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT EnterpriseID,Email,Password,Name,Category,RUC,Status FROM Enterprise WHERE Email= ? and Password=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objEnterprise.getEmail());
            ps.setString(2, objEnterprise.getPassword());
            ResultSet rs = ps.executeQuery();

            rs.next();
            Enterprise obj = new Enterprise();
            obj.setEnterpriseID(rs.getInt("EnterpriseID"));
            obj.setEmail(rs.getString("Email"));
            obj.setPassword(rs.getString("Password"));
            obj.setName(rs.getString("Name"));
            obj.setCategory(rs.getString("Category"));
            obj.setRUC(rs.getInt("RUC"));
            obj.setStatus(rs.getString("Status"));

            return obj;
        } catch (SQLException ex) {
            return null;
            //   throw new RuntimeException(ex.getMessage());
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

    public void addEnterprise(Enterprise objEnterprise) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Enterprise WHERE EnterpriseID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objEnterprise.getEnterpriseID());
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                throw new SQLException("El codigo de la Empresa ya existe");
            }

            query = new StringBuilder();
            query.append("INSERT INTO Enterprise(Email,Password,Name,Category,RUC,Status) VALUES(?,?,?,?,?,?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, objEnterprise.getEmail());
            ps.setString(2, objEnterprise.getPassword());
            ps.setString(3, objEnterprise.getName());
            ps.setString(4, objEnterprise.getCategory());
            ps.setInt(5, objEnterprise.getRUC());
            ps.setString(6, objEnterprise.getStatus());
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

    public void editEnterprise(Enterprise objEnterprise) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Enterprise SET Email = ?,Password = ?,Name=?,Category = ?,RUC = ?,Status=? WHERE EnterpriseID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objEnterprise.getEmail());
            ps.setString(2, objEnterprise.getPassword());
            ps.setString(3, objEnterprise.getName());
            ps.setString(4, objEnterprise.getCategory());
            ps.setInt(5, objEnterprise.getRUC());
            ps.setString(6, objEnterprise.getStatus());
            ps.setInt(7, objEnterprise.getEnterpriseID());

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

    public void deleteEnterprise(Enterprise objEnterprise) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("DELETE FROM Enterprise WHERE EnterpriseID = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setInt(1, objEnterprise.getEnterpriseID());
            int realizado = ps.executeUpdate();
            if (realizado == 0) {
                throw new SQLException("Empresa no existe!");
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
    
    public List<Enterprise> getEnterprises() {
        Connection cn = null;
        try {
            List<Enterprise> lstEnterprises = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Enterprise");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Enterprise obj = new Enterprise();
                obj.setEnterpriseID(rs.getInt("EnterpriseID"));
                obj.setEmail(rs.getString("Email"));
                obj.setPassword(rs.getString("Password"));
                obj.setName(rs.getString("Name"));
                obj.setCategory(rs.getString("Category"));
                obj.setRUC(rs.getInt("RUC"));
                obj.setStatus(rs.getString("Status"));

                lstEnterprises.add(obj);
            }
            return lstEnterprises;
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

    public List<Enterprise> getEnterprisesByStatus(String status) {
        Connection cn = null;
        try {
            List<Enterprise> lstproducts = new ArrayList<>();
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Enterprise WHERE Status=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, status);
            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Enterprise obj = new Enterprise();
                obj.setEnterpriseID(rs.getInt("EnterpriseID"));
                obj.setEmail(rs.getString("Email"));
                obj.setPassword(rs.getString("Password"));
                obj.setName(rs.getString("Name"));
                obj.setCategory(rs.getString("Category"));
                obj.setRUC(rs.getInt("RUC"));
                obj.setStatus(rs.getString("Status"));

                lstproducts.add(obj);
            }
            return lstproducts;
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
