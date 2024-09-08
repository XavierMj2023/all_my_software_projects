package org.studyeasy;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.studyeasy.interfaces.Car_Autowire;

public class App_Autowire {

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
		Car_Autowire myCar = context.getBean("corollaAutowire" , Car_Autowire.class);
		myCar.specs();
				
		//Closing the context also
		context.close();
		
	}

}
