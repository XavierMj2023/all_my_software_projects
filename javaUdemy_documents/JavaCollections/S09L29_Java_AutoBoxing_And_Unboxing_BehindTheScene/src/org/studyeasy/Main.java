package org.studyeasy;

import java.util.ArrayList;

//User defined Wrapper Class
class IntWrapper{
	public int num;
	
	public int getNum() {
		return num;
	}

	public void setNum(int num) {
		this.num = num;
	}
	
	public IntWrapper(int num) {
		this.num = num;
	}
}
public class Main {

	public static void main(String[] args) {
		
		//We need not to specify the data, the Java Compiler will handle it.
		//ArrayList<String> listNames = new ArrayList<String>();
		
		//Exception in thread "main" java.lang.Error: Unresolved compilation problem: 
		//Syntax error, insert "Dimensions" to complete ReferenceType
		//Works on objects and not on primitive type - ArrayList
		// ArrayList<int> numbersList = new ArrayList<>();
		
		//Solution fo rthe above problem - Use 'Integer' instead of int.
		//In-Built Wrapper
		ArrayList<Integer> numbersList = new ArrayList<>();
		numbersList.add(25);
		numbersList.add(28);
		System.out.println(numbersList);
		
		//Autoboxing
		ArrayList<Integer> numbersList2 = new ArrayList<>();
		numbersList2.add(25);
		System.out.println(numbersList2.get(0)); //Auto Unboxing
		
		//Autoboxing Complain
		/*
		 * Exception in thread "main" java.lang.Error: 
		 * Unresolved compilation problem: 
		 * The method add(int, IntWrapper) in the type ArrayList<IntWrapper> is 
		 * not applicable for the arguments (int)
		 * 
		 * Boxing will no longer work
		 * Manually Box
		 */
		/*
		 * ArrayList<IntWrapper> numbersList3 = new ArrayList<>(); 
		 * numbersList3.add(25);
		 * System.out.println(numbersList3.get(0));
		 */
		
		ArrayList<IntWrapper> numbersList3 = new ArrayList<>();
		numbersList3.add(new IntWrapper(65)); //Boxing
		System.out.println(numbersList3.get(0));//Unboxing 
		//Getting object rather than data
		//o/p -> org.studyeasy.IntWrapper@1c4af82c
		//So Use need to do extra that is use getter method
		
		System.out.println(numbersList3.get(0).getNum());//Unboxing 
		
		ArrayList<Double> numbersList4 = new ArrayList<>();
		//numbersList4.add(25.5);//Behind The Scene it will be using valueOf()
		numbersList4.add(Double.valueOf(25.5)); //Autoboxing
		System.out.println("------Collection Behind the Scene--------");
		System.out.println(numbersList4);//[25.5]
		System.out.println(numbersList4.get(0));//25.5
		System.out.println(numbersList4.get(0).doubleValue());//25.5 //Unboxing
		
		
	}	
}
