package org.studyeasy;

public class App {

	public static void main(String[] args) {
		
		//First Trial
		B obj1 = new B();
		
		//This is coming from Class B which is overriden
		obj1.india();
		
		//This is coming from Class A
		obj1.USA();
	}

}
