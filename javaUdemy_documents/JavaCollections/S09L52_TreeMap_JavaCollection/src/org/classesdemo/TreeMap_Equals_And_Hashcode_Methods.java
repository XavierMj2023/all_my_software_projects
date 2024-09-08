package org.classesdemo;

public class TreeMap_Equals_And_Hashcode_Methods {
	
	public static void TreeMap_EqualAndHashCode() {
		String x1 = "Study";
		x1+="Easy";
		String x2 = "StudyEasy";
		
		System.out.println("The value of x1 is "+x1);
		System.out.println("The value of x2 is "+x2);
		
		System.out.println("This is the comparision between x2 and string StudyEasy :");
		System.out.println(x2 == "StudyEasy");
		
		System.out.println("This is the comparision between x1 and string StudyEasy :");
		System.out.println(x1 == "StudyEasy");
		
		System.out.println("This is the comparision between x1 and x2 :");
		System.out.println(x1 == x2);
	}
	public static void TreeMap_Equals() {
		String x1 = "Study";
		x1+="Easy";
		String x2 = "StudyEasy";
		
		System.out.println("The value of x1 is "+x1);
		System.out.println("The value of x2 is "+x2);
		
		
		System.out.println("This is the comparision between x1 and x2 :");
		System.out.println(x1.equals(x2));
	}
	public static void TreeMap_HashCode() {
		String x1 = "Study";
		x1+="Easy";
		String x2 = "StudyEasy";
		
		System.out.println("The value of x1 is "+x1);
		System.out.println("The value of x2 is "+x2);
		
		
		System.out.println("This is the comparision between x1 and x2 :");
		System.out.println(x1.equals(x2));
		
		//Now let's use HashCode to find out more details
		System.out.println("The value of x1 is "+x1.hashCode());
		System.out.println("The value of x2 is "+x2.hashCode());
		
		System.out.println("This is the comparision between x1 and x2 with HashCode():");
		System.out.println(x1.equals(x2));
		
	}
	public static void TreeMap_HashCode_With_EqualOpeartor() {
		String x1 = "Study";
		x1+="Easy";
		String x2 = "StudyEasy";
		
		System.out.println("The value of x1 is "+x1);
		System.out.println("The value of x2 is "+x2);
		
		
		System.out.println("This is the comparision between x1 and x2 :");
		System.out.println(x1.equals(x2));
		
		//Now let's use HashCode to find out more details
		System.out.println("The value of x1 is "+x1.hashCode());
		System.out.println("The value of x2 is "+x2.hashCode());
		
		System.out.println("This is the comparision between x1 and x2 with HashCode() and == :");
		System.out.println(x1==x2);
		
	}
}
