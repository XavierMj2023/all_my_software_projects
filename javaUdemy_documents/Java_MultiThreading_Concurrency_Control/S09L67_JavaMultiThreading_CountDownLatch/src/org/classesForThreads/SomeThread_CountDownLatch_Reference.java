package org.classesForThreads;

import java.util.concurrent.CountDownLatch;

public class SomeThread_CountDownLatch_Reference extends Thread {
	
	private CountDownLatch latch;
	
	public SomeThread_CountDownLatch_Reference(CountDownLatch latch) {
		this.latch = latch;
	}

	@Override
	public void run() {
		
		System.out.println("Started Thread: "+Thread.currentThread().getName());
		System.out.println("Ended Thread: "+Thread.currentThread().getName());
		System.out.println("*************************");
	}
}
