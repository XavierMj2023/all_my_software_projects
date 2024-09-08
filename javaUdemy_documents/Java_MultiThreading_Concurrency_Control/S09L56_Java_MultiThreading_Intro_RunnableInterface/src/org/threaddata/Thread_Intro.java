package org.threaddata;

import org.classWhichWeUseForSomePurpose.MyCounterExtendsRunnableInterface;
import org.classWhichWeUseForSomePurpose.MyCounter_RandomizeSleep;
import static java.lang.Thread.sleep;

public class Thread_Intro {
	
	public static void Thread_Class_RunnableInterface() throws InterruptedException{
		
		Thread thread1 = new Thread(new MyCounterExtendsRunnableInterface(1));
		Thread thread2 = new Thread(new MyCounterExtendsRunnableInterface(2));
		thread1.start();
		thread2.start();
	}
	public static void Thread_Class_RunnableInterface_RandomizeSleep() throws InterruptedException{
		
		Thread thread1 = new Thread(new MyCounter_RandomizeSleep(1));
		Thread thread2 = new Thread(new MyCounter_RandomizeSleep(2));
		thread1.start();
		thread2.start();
	}
	public static void Thread_Class_RunnableInterface_AnonymousClass() throws InterruptedException{
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i< 10; i++) {
					try {
						sleep(500);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					System.out.println(i);
				}	
			}
		});
		
		thread1.start();
	}
	public static void Thread_Class_RunnableInterface_AnonymousClass_MicroThread() throws InterruptedException{
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i< 10; i++) {
					try {
						sleep(500);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					System.out.println(i);
				}	
			}
		});
		
		thread1.start();
	}
}
