package org.usemclasses;

public class Brackets_With_SynchronizedBlock_Mimic {
	
	synchronized public void generate() throws InterruptedException {
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
}
