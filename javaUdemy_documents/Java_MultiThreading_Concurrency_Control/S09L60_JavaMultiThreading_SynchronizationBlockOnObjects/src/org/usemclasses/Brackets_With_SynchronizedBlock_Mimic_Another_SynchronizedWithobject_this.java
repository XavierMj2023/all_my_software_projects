package org.usemclasses;

public class Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWithobject_this {
	
	 public void generate() throws InterruptedException {
		 
		//This is locked and cannot be paused when it comes out to executing part.
		//of the method.
		//Synchronized Block
		synchronized(this) {
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
