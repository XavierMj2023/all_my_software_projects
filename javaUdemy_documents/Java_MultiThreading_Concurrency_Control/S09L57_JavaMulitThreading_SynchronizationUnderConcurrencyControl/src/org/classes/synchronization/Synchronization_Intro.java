package org.classes.synchronization;

public class Synchronization_Intro {
	
	public static int counter = 0;
	
	public static void Synchronization_Exe() throws InterruptedException{
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i < 100000; i++) {
					Synchronization_Intro.counter++;
				}
			}
		}).start();
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i < 100000; i++) {
					Synchronization_Intro.counter++;
				}
			}
		}).start();
		
		System.out.println(counter);//9999
	}
	
	public static void Synchronization_Exe_Part2() throws InterruptedException {
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i <= 100000; i++) {
					Synchronization_Intro.counter++;
				}
				System.out.println("The Loop in thread 1 is over");
			}
		}).start();
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i <= 100000; i++) {
					Synchronization_Intro.counter++;
				}
				System.out.println("The Loop in thread 2 is over");
			}
		}).start();
		
		System.out.println(counter);
	}
	
	public static void Synchronization_Exe_With_SleepMethod() throws InterruptedException{
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i < 100000; i++) {
					Synchronization_Intro.counter++;
				}
				System.out.println("The Loop in thread 1 is over");
			}
		}).start();
		
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 1; i < 100000; i++) {
					Synchronization_Intro.counter++;
				}
				System.out.println("The Loop in thread 2 is over");
			}
		}).start();
		Thread.sleep(500);
		System.out.println(counter);
	}
}
