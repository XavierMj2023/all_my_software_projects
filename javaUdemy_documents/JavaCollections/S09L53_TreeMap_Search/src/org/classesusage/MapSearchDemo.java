package org.classesusage;

import java.util.Map;
import java.util.TreeMap;
import org.classforusage.CodeClassUpdated;

public class MapSearchDemo {
	
	public static void MapSearch() {
		Map<CodeClassUpdated,String> map = new TreeMap<>();
		map.put(new CodeClassUpdated("S11","11"), "Chaand");
		map.put(new CodeClassUpdated("S11","22"), "Rahul");
		map.put(new CodeClassUpdated("S11","00"), "Alex");
		map.put(new CodeClassUpdated("S11","05"), "John");
		map.put(new CodeClassUpdated("S10","10"), "Aafiya");
		map.put(new CodeClassUpdated("S11","10"), "Chaand");
		
		//One way to get a value
		System.out.println(map.get(new CodeClassUpdated("S11","11")));
	}
	public static void MapSearch_Using_KnownValue_But_UnderstandKey() {
		
		Map<CodeClassUpdated,String> map = new TreeMap<>();
		map.put(new CodeClassUpdated("S11","11"), "Chaand");
		map.put(new CodeClassUpdated("S11","22"), "Rahul");
		map.put(new CodeClassUpdated("S11","00"), "Alex");
		map.put(new CodeClassUpdated("S11","05"), "John");
		map.put(new CodeClassUpdated("S10","10"), "Aafiya");
		map.put(new CodeClassUpdated("S11","10"), "Chaand");
		
		CodeClassUpdated code =  null;
		
		for (CodeClassUpdated key: map.keySet()) {
			if(map.get(key).equals("Alex")){
				code = key;
				break;
			}
		}
		System.out.println(code);
	}
}
