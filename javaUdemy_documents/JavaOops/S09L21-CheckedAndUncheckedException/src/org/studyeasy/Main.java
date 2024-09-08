package org.studyeasy;

import java.io.FileNotFoundException;

public class Main {

	public static void main(String[] args) {
		Main main = new Main();
		main.doSomething();
	}
	public void doSomething(){
		String x = "zero";
		if(x.equals("zero")) {
			//Unchecked Exception 
			//throw new RuntimeException();
			
			//Checked Exception  
			//throw new FileNotFoundException();
		}
		System.out.println("Do something");
	}
}
