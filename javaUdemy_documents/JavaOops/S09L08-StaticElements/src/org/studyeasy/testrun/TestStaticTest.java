package org.studyeasy.testrun;

//public static class TestStaticTest --> You get error
public class TestStaticTest {
	// This is not static variable
	// private int staticVariable = 0;
	
	// This is static variable
	 private static int staticVariable = 0;

	/*
	 * public int getStaticVariable() { return staticVariable; }
	 * 
	 * public void setStaticVariable(int staticVariable) { 
	 * 		this.staticVariable =
	 * 		staticVariable; 
	 * }
	 */
	
	 //Making changes here
	 public static int getStaticVariable() { 
		 return staticVariable; 
	}
	 public static void setStaticVariable(int staticVariable) { 
		 TestStatic.staticVariable = staticVariable; 
	}
}
