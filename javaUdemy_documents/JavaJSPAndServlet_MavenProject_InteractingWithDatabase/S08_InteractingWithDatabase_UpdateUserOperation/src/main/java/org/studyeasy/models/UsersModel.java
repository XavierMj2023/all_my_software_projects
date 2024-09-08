package org.studyeasy.models;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import org.studyeasy.config.DatabaseConfig;
import org.studyeasy.entity.User;

//This Class can connect to database and get the information we need.
public class UsersModel {
	public List<User> listusers() {
		List<User> listusers = new ArrayList<User>();

		// Step1: Connection Object Initialization
		Connection connect = DatabaseConfig.getConnection();

		// Statement Objects - It will help us to create and execute statements or
		// queries in the database.
		Statement stmt = null;

		// Result Set - It will be required to store the results from the database.
		// The datatype of the result is ResultSet.
		// We have to iterate over the ResultSet to extract information.
		ResultSet rs = null;

		// Step2: Create the DB query
		String query = "Select * from users";
		try {
			stmt = connect.createStatement();

			// Step3: Executation of statement

			// We get a result set.
			rs = stmt.executeQuery(query);

			// Iterating over the resultset
			while (rs.next()) {
				listusers.add(new User(rs.getInt("user_id"), rs.getString("username"), rs.getString("email")));
			}

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return listusers;
	}

	public void addUser(User newUser) {
		Connection connect = null;
		PreparedStatement statement = null;
		try {
			connect = DatabaseConfig.getConnection();
			String username = newUser.getUsername();
			String email = newUser.getEmail();
			String query = "insert into users (username, email) values (?, ?)";
			statement = connect.prepareStatement(query);
			statement.setString(1, username);
			statement.setString(2, email);
			statement.execute();
			
		}catch(SQLException e) {
			e.printStackTrace();
		}
	}
	
	public void updateUser(User updatedUser) {
		Connection connect = null;
		PreparedStatement statement = null;
		try {
			connect = DatabaseConfig.getConnection();
			int user_Id = updatedUser.getUser_id();
			String username = updatedUser.getUsername();
			String email = updatedUser.getEmail();
			String query = "update users set username = ? , email = ? where user_Id = ?";
			statement = connect.prepareStatement(query);
			statement.setString(1, username);
			statement.setString(2, email);
			statement.setInt(3, user_Id);
			statement.execute();
			
		}catch(SQLException e) {
			e.printStackTrace();
		}
	}
	
	public void deleteUser(int userID) {
		Connection connect = null;
		PreparedStatement statement = null;
		try {
			connect = DatabaseConfig.getConnection();
			String query = "delete from users where user_Id = ?";
			statement = connect.prepareStatement(query);
			statement.setInt(1, userID);
			statement.execute();
			
		}catch(SQLException e) {
			e.printStackTrace();
		}
	}
}
