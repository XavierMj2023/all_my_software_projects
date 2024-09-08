package org.classWhichWeUseForSomePurpose;

public class MyCounterExtendsThreadClass extends Thread{
	
	private int threadNo;

	public MyCounterExtendsThreadClass(int threadNo) {
		this.threadNo = threadNo;
	}
	
	@Override
	public void run() {
		try {
			countMe();
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void countMe() throws InterruptedException {
		for(int i = 0; i< 10; i++) {
			sleep(500);
			System.out.println("Thread No : "+threadNo +" and Iteration no : "+i);
		}
	}
}
