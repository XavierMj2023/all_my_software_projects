package org.maincallsforclasses;

import org.usemclasses.Brackets_With_SynchronizedBlock;
import org.usemclasses.Brackets_With_SynchronizedBlock_Mimic;
import org.usemclasses.Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWithobject_this;

public class SynchronizationBlock_Intro {

	public static void SynchronizationBlock() {
		
		Brackets_With_SynchronizedBlock brackets = new Brackets_With_SynchronizedBlock();
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
	public static void SynchronizationBlock_Mimic() {
		
		Brackets_With_SynchronizedBlock_Mimic brackets = new Brackets_With_SynchronizedBlock_Mimic();
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
	public static void SynchronizationBlock_Mimic_With_AnotherForLoop() {
		
		Brackets_With_SynchronizedBlock_Mimic brackets = new Brackets_With_SynchronizedBlock_Mimic();
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
	public static void Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWith_object_this() {
		
		Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWithobject_this brackets = new Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWithobject_this();
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
