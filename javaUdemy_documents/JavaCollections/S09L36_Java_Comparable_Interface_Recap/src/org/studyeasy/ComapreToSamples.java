package org.studyeasy;

public class ComapreToSamples {
	public void CallComapreToSamples() {
		/*
		 * So, it actually calculates the difference between objects and gives 
		 * proper result based on natural ordering
		 */
		System.out.println("---ComapreTo Samples--------");
		System.out.println("------------------------------");
		
		//Case 1
		String x = "abc";
		String y = "xyz";
		
		System.out.println("Case 1 : "+x.compareTo(y));//-23
		
		//Case 2
		String x2 = "a";
		String y2 = "x";
		
		System.out.println("Case 2 : "+x2.compareTo(y2));//-23
		
		//Case 3
		String x3 = "a";
		String y3 = "b";
				
		System.out.println("Case 3 : "+x3.compareTo(y3));//-1
		
		//Case 4
		String x4 = "a";
		String y4 = "c";
						
		System.out.println("Case 4 : "+x4.compareTo(y4));//-2
		
		//Case 5
		String x5 = "a";
		String y5 = "a";
								
		System.out.println("Case 5 : "+x5.compareTo(y5));//0
		
		//Case 6
		String x6 = "A";
		String y6 = "a";
										
		System.out.println("Case 6 : "+x6.compareTo(y6));//-32
		
		//Case 7
		String x7 = "a";
		String y7 = "A";
												
		System.out.println("Case 7 : "+x7.compareTo(y7));//32
		
		System.out.println("------------------------------");
		System.out.println("---ComapreTo Samples--------");
	}
}
