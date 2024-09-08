package org.usemclasses;

public class Brackets_With_SynchronizedBlockOnObject {
	
	 private Object lock = "lock";
	
	 public void generate() throws InterruptedException {
		 
		synchronized(lock) {
		for(int i = 1; i <= 20; i++) {
			Thread.sleep(5);
			if(i <= 10) {
				System.out.print('[');
			}else {
				System.out.print(']');
			}
		}
		System.out.println();
	 }
		for(int i = 0; i < 10; i++) {
			Thread.sleep(10);
		}
	}
}
