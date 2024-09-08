package org.studyeasy;

import java.util.Scanner;

import org.classesdemo.TreeMap_Can_we_use_Equals_Method_for_CustomObjects;
import org.classesdemo.TreeMap_CustomObject;
import org.classesdemo.TreeMap_Equals_And_Hashcode_Methods;
import org.classesdemo.TreeMap_Working;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//TreeMap Working
			TreeMap_Working.TreeMapDemo();
			break;
		case 2:
			//TreeMap Working with sequence change
			TreeMap_Working.TreeMapDemo_ChangeSequence();
			break;
		case 3:
			//Using Custom Object - Error
			TreeMap_CustomObject.TreeCustomObj();
			break;
		case 4:
			//Using Custom Object - Solution
			TreeMap_CustomObject.TreeCustomObj_With_Comparator();
			break;
		case 5:
			//Using Custom Object - Solution - Updated
			TreeMap_CustomObject.TreeCustomObj_With_Comparator_Updated();
			break;
		case 6:
			//Using TreeMap Methods - Equals() and HashCode()_WhyIsItUsed?
			TreeMap_Equals_And_Hashcode_Methods.TreeMap_EqualAndHashCode();
			break;
		case 7:
			//Using TreeMap Methods - Equals()
			TreeMap_Equals_And_Hashcode_Methods.TreeMap_Equals();
			break;
		case 8:
			//Using TreeMap Methods - HashCode()
			TreeMap_Equals_And_Hashcode_Methods.TreeMap_HashCode();
			break;
		case 9:
			//Using TreeMap Methods - HashCode() and == operator to compare
			TreeMap_Equals_And_Hashcode_Methods.TreeMap_HashCode_With_EqualOpeartor();
			break;
		case 10:
			//Can we use Equals() for Custom Objects
			TreeMap_Can_we_use_Equals_Method_for_CustomObjects.TreeMap_Can_use_Equals_Method_for_CustomObjects();
			break;
		case 11:
			//Can we use Equals() for Custom Objects - ComparingUsingEquals()
			TreeMap_Can_we_use_Equals_Method_for_CustomObjects.TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals();
			break;
		case 12:
			//Can we use Equals() for Custom Objects - ComparingUsingEquals()_OverridingMethods_HashCode And Equals
			TreeMap_Can_we_use_Equals_Method_for_CustomObjects.TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals_OverridingMethods();
			break;
		case 13:
			//Can we use Equals() for Custom Objects - ComparingUsingEquals()_OverridingMethods_HashCode And Equals
			//Whether == works or not
			TreeMap_Can_we_use_Equals_Method_for_CustomObjects.TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals_OverridingMethods_EqualsOpeartorWorkOrNot();
			break;
		}
		sc.close();
	}

}
