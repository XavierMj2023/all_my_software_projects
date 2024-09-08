package org.studyeasy;

public class Main {

	public static void main(String[] args) {
		//int is a keyword and has a different syntax highlighting
		
		//Every Datatype in Java except String is implemented as a primitive datatype.
		
		//String x = "Chaand";
		//int y = 10;
		
		String a = "study";
		String b = "easy";
		String c = a.concat(b);
		c = c.replace("easy", "hard");
		System.out.println(c);
		if(a.equals("studyhard")) {
			System.out.println("Great");
		}else {
			System.out.println("What just happened");
		}
	}
}
