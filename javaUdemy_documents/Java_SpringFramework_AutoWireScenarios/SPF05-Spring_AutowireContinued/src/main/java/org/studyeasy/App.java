package org.studyeasy;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.studyeasy.interfaces.Car;

public class App {
	public static void main(String[] args) {

		// Outsourcing Object Creation process
		AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(AppConfig.class);

		// Outsource the work to Spring.
		Car myCar = context.getBean("co", Car.class);
		myCar.specs();

		// Closing the context also
		context.close();

	}
}
