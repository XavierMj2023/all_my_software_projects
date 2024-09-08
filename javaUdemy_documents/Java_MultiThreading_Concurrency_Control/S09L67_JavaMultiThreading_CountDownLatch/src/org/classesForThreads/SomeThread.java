package org.classesForThreads;

public class SomeThread extends Thread {
	
	@Override
	public void run() {
		
		System.out.println("Started Thread: "+Thread.currentThread().getName());
		System.out.println("Ended Thread: "+Thread.currentThread().getName());
		System.out.println("*************************");
	}
}
