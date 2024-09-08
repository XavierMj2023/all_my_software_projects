package org.studyeasy;

public class Main {

	public static void main(String[] args) {
		/*
		 * Basic Intialization and understanding of Array
		 * 
		 * String[] names; names = new String[10]; names[0] = "Chaand"; names[5] =
		 * "studyeasy"; System.out.println(names[5]);
		 */
		
		/*
		 * Integer DataType Array
		 * 
		 * int[] values; values = new int[10]; System.out.println(values[0]);
		 */
		
		/*
		 * Float DataType Array
		 * 
		 * float[] values2; values2 = new float[10]; System.out.println(values2[0]);
		 */
		
		/*
		 * Double Array Element Recogniation
		 * 
		 * double[] values3 = {10.0, 25.1252142, 60};
		 * System.out.println(" The value of the array element 0 : "+values3[0]);
		 * System.out.println(" The value of the array element 1 : "+values3[1]);
		 * System.out.println(" The value of the array element 2 : "+values3[2]);
		 */
		 
		
		/*
		 * Floating Point Error (Double and Float)
		 * 
		 * float[] values3 = {10.0, 25.1252142, 60}; System.out.println(values3[2]);
		 */
		
		/*
		 * float[] values3 = {10.0f, 25.1252142f, 60};
		 * System.out.println(" The value of the array element 0 : "+values3[0]);
		 * System.out.println(" The value of the array element 1 : "+values3[1]); //Here
		 * 2 at decimal point for the given literal gets //truncated
		 * System.out.println(" The value of the array element 2 : "+values3[2]);
		 */
		
		 //ForEach Loop
		 //ForEachDemo.ForEachExe();
		
		 /*
		  * Call By Value Demo
		  * 
		  * int value = 10; CallByValueDemo cbyd = new CallByValueDemo();
		  * cbyd.CallByValueExeCase1(value);
		  * System.out.println("Call from the main method : "+value);
		 */
		
		  String[] names = {"Tom","Chaand","Study","Easy","Raj"};
		  //System.out.println(names);
		  System.out.println(names[0]);
		  CallByReferenceDemo cbrefer = new CallByReferenceDemo();
		  cbrefer.CallByReferenceExeCase1(names);
		  System.out.println("New Value : "+names[0]);
	}

}
