package org.classWhichWeUseForSomePurpose;

import static java.lang.Thread.sleep;

public class MyCounterExtendsRunnableInterface implements Runnable{
	
	private int threadNo;

	public MyCounterExtendsRunnableInterface(int threadNo) {
		this.threadNo = threadNo;
	}

	@Override
	public void run() {
		for(int i = 0; i< 10; i++) {
			try {
				sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			System.out.println("Thread No : "+threadNo +" and Iteration no : "+i);
		}	
	}
	
}
