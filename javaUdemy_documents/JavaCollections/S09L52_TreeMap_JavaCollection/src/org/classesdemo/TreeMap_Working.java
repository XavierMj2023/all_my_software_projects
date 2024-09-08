package org.classesdemo;

import java.util.Map;
import java.util.TreeMap;

public class TreeMap_Working {
	
	public static void TreeMapDemo() {
		Map<String,String> map = new TreeMap<>();
		map.put("a1", "Chaand");
		map.put("a2", "Alex");
		map.put("a2", "Rahul");//Latest Updated in TreeMap ; same key different value
		map.put("a5", "John");
		map.put("a0", "Aafiya");
		map.put("a9", "Chaand");
		System.out.println(map);
	}
	
	public static void TreeMapDemo_ChangeSequence() {
		Map<String,String> map = new TreeMap<>();
		map.put("a1", "Chaand");
		map.put("a2", "Rahul");
		map.put("a2", "Alex");//Latest Updated in TreeMap ; same key different value
		map.put("a5", "John");
		map.put("a0", "Aafiya");
		map.put("a9", "Chaand");
		System.out.println(map);
	}
}
