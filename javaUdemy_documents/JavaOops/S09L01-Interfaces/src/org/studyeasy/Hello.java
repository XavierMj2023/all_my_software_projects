package org.studyeasy;

import org.studyeasy.phone.Iphone8;
import org.studyeasy.phone.OnePlus5;
import org.studyeasy.phone.OnePlus5WithInterface;
import org.studyeasy.phone.OnePlus5WithReturnTypeString;
import org.studyeasy.phone_interface.Phone;

public class Hello {

	public static void main(String[] args) {
		//Create an Object Of OnePlus5.
		
		/*
		OnePlus5 phone = new OnePlus5();
		int processor = phone.processor();
		System.out.println("Processor : "+processor);
		*/
		
		//-------------------------------------------------------
		//Create an Object Of OnePlus5WithReturnTypeString.
		//No Restriction on the developer.
		
		/*
		OnePlus5WithReturnTypeString phone = new OnePlus5WithReturnTypeString();
		int processor = phone.processor();
		System.out.println("Processor : "+processor);
		*/
		
		//-------------------------------------------------------
		// Phone is the Interface and OnePlus5WithInterface is the Class.
		// An Interface which is implemented by our class OnePlus5WithInterface.
		// Not Updating line of statement ;But shift or switch between classes.
		// Restriction is there.
		
		// Phone phone = new OnePlus5WithInterface(); //SD835
		
		 Phone phone = new Iphone8(); //All
		 System.out.println("Processor : "+phone.processor());
		 System.out.println("Space in GB : "+phone.spaceInGB());
		
		
	}

}
