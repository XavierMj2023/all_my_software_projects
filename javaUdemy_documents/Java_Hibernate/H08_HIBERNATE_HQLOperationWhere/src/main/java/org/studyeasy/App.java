package org.studyeasy;

import java.util.List;

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
		
			//Start Transaction
			session.beginTransaction();
			
			//Where
			//hibusers is entity name
			List<Users> users = session.createQuery("from hibusers where username='Ash' OR "
					+ "password like '%981'").getResultList();
			
			for(Users temp : users) {
				System.out.println(temp);
			}

		}finally {
			session.close();
			factory.close();
		}
	}
}
