package org.studyeasy.config;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

//This class can be used to initialize the database connection.
public class DatabaseConfig {
	public static Connection getConnection() {
		
		//Initialize all the information regarding
		//Database Connection
		String dbURL = "jdbc:mysql://localhost:8080/users?useSSL=false";
		
		//Database name to access
		String dbUsername = "root";
		String dbPassword = "wizardMDFC30$";
		
		Connection con = null;
		
		//This specifies which driver we will be using to connect to database.
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(dbURL, dbUsername, dbPassword);
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return con;
	}
}
