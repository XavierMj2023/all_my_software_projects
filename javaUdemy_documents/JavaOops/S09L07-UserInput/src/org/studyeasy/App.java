package org.studyeasy;

import java.util.Scanner;

public class App {

	public static void main(String[] args) {
		
		// Without entering the name from user,we get "Hey there, Have a nice day"
		
		/*
		 * System.out.println("What your's name?"); 
		 * Scanner sc = new Scanner(System.in);
		 * String name = sc.nextLine();
		 * System.out.println("Hey there,"+name+" Have a nice day");
		 */
		//------------------------------------------------------------------------------
		// next() - It will wait until we give valid input.
		// Resource leak;'sc' is never closed -> You get warning; Use -> sc.close();
		
		
		  System.out.println("What your's name?"); Scanner sc = new Scanner(System.in);
		  String name = sc.next(); sc.close();
		  System.out.println("Hey there,"+name+" Have a nice day");
		 
		//------------------------------------------------------------------------------
		//Restriction on user input  -> Integer -> nextInt()
		//If you enter string ,you get error java.util.InputMismatchException
		
		/*
		 * System.out.println("What your's age?"); 
		 * Scanner sc = new Scanner(System.in);
		 * int age = sc.nextInt(); 
		 * sc.close(); 
		 * System.out.println("Your age is : "+age);
		 */
		 
	}

}
