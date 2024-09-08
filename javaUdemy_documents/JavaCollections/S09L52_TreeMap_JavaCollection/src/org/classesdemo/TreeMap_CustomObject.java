package org.classesdemo;

import java.util.Map;
import java.util.TreeMap;

import org.classforusage.Code;
import org.classforusage.CodeClassUpdated;

public class TreeMap_CustomObject {
	
	public static void TreeCustomObj() {
		Map<Code,String> map = new TreeMap<>();
		map.put(new Code("S11","10"), "Chaand");
		map.put(new Code("S11","10"), "Rahul");
		map.put(new Code("S11","10"), "Alex");
		map.put(new Code("S11","10"), "John");
		map.put(new Code("S11","10"), "Aafiya");
		map.put(new Code("S11","10"), "Chaand");
		System.out.println(map);
	}
	public static void TreeCustomObj_With_Comparator() {
		Map<CodeClassUpdated,String> map = new TreeMap<>();
		map.put(new CodeClassUpdated("S11","10"), "Chaand");
		map.put(new CodeClassUpdated("S11","10"), "Rahul");
		map.put(new CodeClassUpdated("S11","10"), "Alex");
		map.put(new CodeClassUpdated("S11","10"), "John");
		map.put(new CodeClassUpdated("S11","10"), "Aafiya");
		map.put(new CodeClassUpdated("S11","10"), "Chaand");
		System.out.println(map);
	}
	public static void TreeCustomObj_With_Comparator_Updated() {
		Map<CodeClassUpdated,String> map = new TreeMap<>();
		map.put(new CodeClassUpdated("S11","11"), "Chaand");
		map.put(new CodeClassUpdated("S11","22"), "Rahul");
		map.put(new CodeClassUpdated("S11","00"), "Alex");
		map.put(new CodeClassUpdated("S11","05"), "John");
		map.put(new CodeClassUpdated("S10","10"), "Aafiya");
		map.put(new CodeClassUpdated("S11","10"), "Chaand");
		System.out.println(map);
	}
}
