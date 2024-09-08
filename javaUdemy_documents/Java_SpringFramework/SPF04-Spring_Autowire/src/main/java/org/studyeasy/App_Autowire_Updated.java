package org.studyeasy;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.studyeasy.interfaces.Car_Autowire_Updated;

public class App_Autowire_Updated {

	public static void main(String[] args) {
		
		/*
		 * Car o1 = new Swift(); 
		 * o1.specs();
		 * 
		 * Car o2 = new Swift(); 
		 * o2.specs();
		 */
		
		//---------------------------------------------------------------------
		
		//Outsourcing Object Creation process
		AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(AppConfig.class);
				
		//Outsource the work to Spring.
		Car_Autowire_Updated myCar = context.getBean("corollaU" , Car_Autowire_Updated.class);
		myCar.specs();
				
		//Closing the context also
		context.close();
		
	}

}
