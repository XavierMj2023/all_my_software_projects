package org.studyeasy;

public class CallByValueDemo {
	public void CallByValueExeCase1(int value) {
		System.out.println("Value of variable in the method CallByValueExeCase1 : "+value);
		value = 20;
		System.out.println("Value of variable in the method CallByValueExeCase1 : "+value);
	}
}
