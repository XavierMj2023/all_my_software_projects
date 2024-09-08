package org.studyeasy;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.studyeasy.entity.Users;

public class App {

	public static void main(String[] args) {
		//Session Factory
		SessionFactory factory = new Configuration()
				.configure("hibernate.cfg.xml")
				.addAnnotatedClass(Users.class)
				.buildSessionFactory();

		//Session
		Session session = factory.getCurrentSession();

		//Close the session
		try {
			//Create Object of Entity Class Type
			Users user = new Users();
			
			//Start Transaction
			session.beginTransaction();
			
			//Perform operation
			user = session.get(Users.class, 5);
			
			//One line change for the delete operation
			session.remove(user);
			
			//Commit Transaction
			session.getTransaction().commit();
			System.out.println(user);

		}finally {
			session.close();
			factory.close();
		}
	}
}
