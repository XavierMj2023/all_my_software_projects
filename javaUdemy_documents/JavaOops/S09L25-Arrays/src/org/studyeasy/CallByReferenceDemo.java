package org.studyeasy;

public class CallByReferenceDemo {
	public void CallByReferenceExeCase1(String[] names) {
		 System.out.println(names[0]);
		 names[0] = "John";
	}
}
