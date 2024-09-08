package org.maincallsforclasses;

import org.usemclasses.Brackets_With_SynchronizedBlockOnObject;

public class SynchronizationBlockOnObject {
	
public static void Brackets_With_SynchronizedBlockOnObject() {
		
		Brackets_With_SynchronizedBlockOnObject brackets = new Brackets_With_SynchronizedBlockOnObject();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				long startTime = System.currentTimeMillis();
				for(int i = 0; i < 5; i++) {
				   try {
					brackets.generate();
				} catch (InterruptedException e) {
					
					e.printStackTrace();
				}
			  }
			  long endTime = System.currentTimeMillis();
			  System.out.println("Total Time required by Thread 01 : "+(endTime - startTime));
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				long startTime = System.currentTimeMillis();
				for(int i = 0; i < 5; i++) {
				   try {
					brackets.generate();
				} catch (InterruptedException e) {
					
					e.printStackTrace();
				}
			  }
			  long endTime = System.currentTimeMillis();
			  System.out.println("Total Time required by Thread 02 : "+(endTime - startTime));
			}
		}).start();
	}
}
