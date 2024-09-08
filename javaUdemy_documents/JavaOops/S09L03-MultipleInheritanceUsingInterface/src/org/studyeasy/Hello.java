package org.studyeasy;

import org.studyeasy.Person.NonVegan;
import org.studyeasy.Person.Person;
import org.studyeasy.Person.Vegan;

public class Hello {

	public static void main(String[] args) {
		Person john = new Vegan();
		john.breathe();
		john.eat();
		john.speak();
		john.message();
		
		System.out.println("************************");
		
		Person mia = new NonVegan();
		mia.breathe();
		mia.eat();
		mia.speak();
		mia.message();
	}

}
