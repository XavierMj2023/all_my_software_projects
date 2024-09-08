package org.classWhichWeUseForSomePurpose;

public class MyCounter {
	
	private int threadNo;

	public MyCounter(int threadNo) {
		this.threadNo = threadNo;
	}
	
	public void countMe() {
		for(int i = 0; i< 10; i++) {
			System.out.println("Thread No : "+threadNo +" and Iteration no : "+i);
		}
	}
}
