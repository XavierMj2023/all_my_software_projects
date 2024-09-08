package org.studyeasy;

import org.studyeasy.testrun.TestStatic;

public class App {

	public static void main(String[] args) {
		
		//Non Static Elements Demo
		//------------------------------
		
		/*
		 * //Object of TestStatic Type 
		 * TestStatic obj1 = new TestStatic();
		 * System.out.println("Obj1 current variable value is : "+obj1.getStaticVariable());//0
		 * 
		 * //Set Value for variable obj1.setStaticVariable(1);
		 * System.out.println("Obj1 current variable value is : "+obj1.getStaticVariable());//1
		 * 
		 * //Another object of TestStatic Type 
		 * TestStatic obj2 = new TestStatic();
		 * System.out.println("Obj2 current variable value is : "+obj2.getStaticVariable());//0
		 * 
		 * //Set Value for variable 
		 * obj2.setStaticVariable(24);
		 * System.out.println("Obj2 current variable value is : "+obj2.getStaticVariable());//24
		 * 
		 * //Another object of TestStatic Type with Static Element TestStatic obj3 = new
		 * TestStatic(); System.out.println("Obj3 current variable value is : "+obj3.getStaticVariable());//24
		 */		 
		 
		//Static Elements Demo
		//------------------------------
		
		/*
		 * //Object of TestStatic Type 
		 * TestStatic obj1 = new TestStatic();
		 * System.out.println("Obj1 current variable value is : "+TestStatic.getStaticVariable());//0
		 * 
		 * //Set Value for variable 
		 * TestStatic.setStaticVariable(1);
		 * System.out.println("Obj1 current variable value is : "+TestStatic.getStaticVariable());//1
		 * 
		 * //Another object of TestStatic Type 
		 * TestStatic obj2 = new TestStatic();
		 * System.out.println("Obj2 current variable value is : "+TestStatic.getStaticVariable());//1
		 * 
		 * //Set Value for variable 
		 * TestStatic.setStaticVariable(24);
		 * System.out.println("Obj2 current variable value is : "+TestStatic.getStaticVariable());//24
		 * 
		 * //Another object of TestStatic Type with Static Element 
		 * TestStatic obj3 = new TestStatic();
		 * System.out.println("Obj3 current variable value is : "+TestStatic.getStaticVariable());//24
		 */		
		
		//Getting rid of the object and modifying them
		//--------------------------------------------
		
		  //Object of TestStatic Type
		  System.out.println("Current variable value is : "+TestStatic.getStaticVariable());//0
		  
		  //Set Value for variable 
		  TestStatic.setStaticVariable(1);
		  System.out.println("Current variable value is : "+TestStatic.getStaticVariable());//1
		  
		  //Set Value for variable 
		  TestStatic.setStaticVariable(24);
		  System.out.println("Current variable value is : "+TestStatic.getStaticVariable());//24
	}
}
