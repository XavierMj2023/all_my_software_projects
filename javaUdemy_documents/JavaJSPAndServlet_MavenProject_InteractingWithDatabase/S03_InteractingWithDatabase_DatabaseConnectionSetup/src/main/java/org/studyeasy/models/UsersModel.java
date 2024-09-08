package org.studyeasy.models;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import org.studyeasy.config.DatabaseConfig;
import org.studyeasy.entity.User;

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
}
