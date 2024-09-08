package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

public class CompareToMethod {
	public void CallCompareTo() {
		//CompareTo() is used for custom sorting mechanism
		int result;
		List<String> data = new LinkedList<>();
		data.add("a");
		result = data.get(0).compareTo("a");
		System.out.println(result);//0
	}
}
