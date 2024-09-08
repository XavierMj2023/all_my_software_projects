package org.classWhichWeUseForSomePurpose;

import static java.lang.Thread.sleep;

public class MyCounterUpdated {
	
	private int threadNo;

	public MyCounterUpdated(int threadNo) {
		this.threadNo = threadNo;
	}
	
	public void countMe() throws InterruptedException {
		for(int i = 0; i< 10; i++) {
			sleep(500);
			System.out.println("Thread No : "+threadNo +" and Iteration no : "+i);
		}
	}
}
