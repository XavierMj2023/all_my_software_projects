package org.classesdemo;

import java.util.HashMap;
import java.util.Map;

public class Map_With_DuplicateKeyAndValues {
	
	public static void MapWith_DuplicateKeyAndValues() {
		Map<String,String> map = new HashMap<>();
		map.put("a1", "Chaand");
		map.put("a2", "Rahul");
		map.put("a5", "John");
		map.put("a0", "Aafiya");
		map.put("a1", "Chaand");
		map.put("a2", "Rahul");
		map.put("a5", "John");
		map.put("a0", "Aafiya");
		System.out.println(map);
	}
	public static void MapAdd() {
		Map<String,String> map = new HashMap<>();
		map.put("a1", "Chaand");
		map.put("a2", "Rahul");
		map.put("a5", "John");
		map.put("a0", "Aafiya");
		map.put("a9", "Chaand");
		System.out.println(map);
	}
}
