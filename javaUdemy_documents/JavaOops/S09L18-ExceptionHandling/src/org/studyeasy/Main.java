package org.studyeasy;

public class Main {

	public static void main(String[] args) {
		int y = 0,x;
		try {
			System.out.println("Before exception");
			x = (y = 10*10)/0;  //Sub Statement
			System.out.println("The divide by zero exception : "+10/0);
			
			//Partial Exceutation
			
			System.out.println("After exception");
		}catch(ArithmeticException e) {
			System.out.println("Arthimetic exception");
		}
		catch(Exception e) {
			System.out.println("Exception");
		}
		finally {
			System.out.println(y);
		}
		
		//Main main = new Main();
				//main.cse1(10, 5);//2
				//main.cse1(10, 0);//The value of y is 0, a possible exception
				
				//main.cse2(10, 5);//2
				//main.cse2(10, 0);//The value of y is 0, a possible exceptionjava.lang.ArithmeticException: / by zero
				
				
				//-------------------------------------------------------------------------------------------------------
				
				//-------------------------------------------------------------------------------------------------------
	}
	/*
	 * public void cse1(int x, int y) { if(y!= 0) { System.out.println("x/y ="+x/y);
	 * }else { System.out.println("The value of y is 0, a possible excepti=on"); } }
	 * public void cse2(int x, int y) { try { System.out.println("x/y ="+x/y); }
	 * catch(Exception e) {
	 * System.out.println("The value of y is 0, a possible exception"+e); } }
	 */
}
		
