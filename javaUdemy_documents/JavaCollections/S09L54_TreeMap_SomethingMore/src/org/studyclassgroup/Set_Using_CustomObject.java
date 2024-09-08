package org.studyclassgroup;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import org.classforusage.Name;

public class Set_Using_CustomObject {
	
	public static void Set_UsingCustomObject() {
		Set<Name> set = new HashSet<>();
		set.add(new Name("Chaand"));
		set.add(new Name("John"));
		set.add(new Name("Aafiya"));
		set.add(new Name("Mike"));
		set.add(new Name("Rachel"));
		set.add(new Name("Chaand"));
		
		List<Name> list = new ArrayList<>();
		list.addAll(set);
		Collections.sort(list);
		System.out.println(list);
		
		//Binary Search
		System.out.println("The value to be searched is John : " +Collections.binarySearch(list,new Name("John")));
		System.out.println("The value to be searched is john : " +Collections.binarySearch(list,new Name("john")));
	}
}
