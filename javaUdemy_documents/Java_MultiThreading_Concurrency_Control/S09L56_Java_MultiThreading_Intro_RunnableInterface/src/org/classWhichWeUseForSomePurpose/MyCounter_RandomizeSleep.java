package org.classWhichWeUseForSomePurpose;

import static java.lang.Thread.sleep;

import java.util.Random;

public class MyCounter_RandomizeSleep implements Runnable{
	private int threadNo;

	public MyCounter_RandomizeSleep(int threadNo) {
		this.threadNo = threadNo;
	}

	@Override
	public void run() {
		for(int i = 0; i< 10; i++) {
			try {
				Random random = new Random();
				sleep(random.nextInt(1000));
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			System.out.println("Thread No : "+threadNo +" and Iteration no : "+i);
		}	
	}
}
