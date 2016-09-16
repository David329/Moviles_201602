/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.guian.dao;

import com.guian.db.AccessDB;
import com.guian.entities.Admin;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author David
 */
public class AdminDAO {

    public Admin LoginAdmin(Admin objAdmin) {
        Connection cn = null;
        try {
            cn = AccessDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT AdminID,Email,Password,FirstName,LastName FROM Admin WHERE Email= ? and Password=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objAdmin.getEmail());
            ps.setString(2, objAdmin.getPassword());
            ResultSet rs = ps.executeQuery();

            rs.next();
            Admin obj = new Admin();
            obj.setAdminID(rs.getInt("AdminID"));
            obj.setEmail(rs.getString("Email"));
            obj.setPassword(rs.getString("Password"));
            obj.setFirstName(rs.getString("FirstName"));
            obj.setLastName(rs.getString("LastName"));
            
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
}
