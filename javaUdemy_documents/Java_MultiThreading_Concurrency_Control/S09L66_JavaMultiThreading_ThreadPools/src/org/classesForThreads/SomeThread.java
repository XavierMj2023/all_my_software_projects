package org.classesForThreads;

public class SomeThread extends Thread {

	private String name;

	public SomeThread(String name) {
		super(name);
		this.name = name;
	}
	
	@Override
	public void run() {
		System.out.println("Started Thread: "+name);
		try {
			Thread.sleep(3000);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		System.out.println("Ended Thread: "+name);
	}
}
