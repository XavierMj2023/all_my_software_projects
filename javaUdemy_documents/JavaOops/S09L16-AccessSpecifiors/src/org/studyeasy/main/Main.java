package org.studyeasy.main;

import org.studyeasy.Sub;

public class Main {

	public static void main(String[] args) {
		
		//Case 1:
		//Other otherObj = new Other();
		//Here x is in different package
		//Error
		//System.out.println(otherObj.x);
		
		
		//Case 2:
		//Other2 otherObj2 = new Other2();
		//Here x is in same package
		//No Error
		//System.out.println(otherObj2.x);
		
		//Case 3:
		//Other2 otherObj3 = new Other2();
		//Here x is in same package
		//No Error
		// x variable access specifior is 'protected'
		// but it will have no impact
		//System.out.println(otherObj3.x);
		
		//Case 4:
		//Other2 otherObj4 = new Other2();
		//Here x is in same package
		//The field Other2.x is not visible
		// x variable access specifior is 'private'
		// but it will have impact
		//System.out.println(otherObj4.x);
		
		//Case 5:
		//Other2 otherObj5 = new Other2();
		//System.out.println(otherObj5.x);
		//otherObj5.message();
		
		//Case 6:
		Sub sub = new Sub();
		System.out.println(sub.x);
	}

}
