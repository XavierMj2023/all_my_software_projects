package org.classesdemo;

import org.classforusage.CodeClassUpdated;
import org.classforusage.CodeClassWithOverrdingEqualsAndHashCode;

public class TreeMap_Can_we_use_Equals_Method_for_CustomObjects {
	
	public static void TreeMap_Can_use_Equals_Method_for_CustomObjects() {
		
		CodeClassUpdated code1 = new CodeClassUpdated("01","01" );
		CodeClassUpdated code2 = new CodeClassUpdated("01","01" );
		System.out.println(code1 == code2);
		System.out.println("The HashCode of code1 is: "+code1.hashCode());
		System.out.println("The HashCode of code2 is: "+code2.hashCode());
	}
	public static void TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals() {
		
		CodeClassUpdated code1 = new CodeClassUpdated("01","01" );
		CodeClassUpdated code2 = new CodeClassUpdated("01","01" );
		System.out.println(code1.equals(code2));
		System.out.println("The HashCode of code1 is: "+code1.hashCode());
		System.out.println("The HashCode of code2 is: "+code2.hashCode());
	}
	public static void TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals_OverridingMethods() {
	
		CodeClassWithOverrdingEqualsAndHashCode code1 = new CodeClassWithOverrdingEqualsAndHashCode("01","01" );
		CodeClassWithOverrdingEqualsAndHashCode code2 = new CodeClassWithOverrdingEqualsAndHashCode("01","01" );
		System.out.println(code1.equals(code2));
		System.out.println("The HashCode of code1 is: "+code1.hashCode());
		System.out.println("The HashCode of code2 is: "+code2.hashCode());
	}
	public static void TreeMap_Can_use_Equals_Method_for_CustomObjects_ComparingUsingEquals_OverridingMethods_EqualsOpeartorWorkOrNot() {
		
		CodeClassWithOverrdingEqualsAndHashCode code1 = new CodeClassWithOverrdingEqualsAndHashCode("01","01" );
		CodeClassWithOverrdingEqualsAndHashCode code2 = new CodeClassWithOverrdingEqualsAndHashCode("01","01" );
		System.out.println(code1 == code2);
		System.out.println("The HashCode of code1 is: "+code1.hashCode());
		System.out.println("The HashCode of code2 is: "+code2.hashCode());
	}
}
