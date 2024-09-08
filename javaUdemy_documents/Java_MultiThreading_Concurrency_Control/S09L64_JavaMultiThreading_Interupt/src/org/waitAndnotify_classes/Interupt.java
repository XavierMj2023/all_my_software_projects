package org.waitAndnotify_classes;

import org.classesForTheBankScenarios_Interupt.InteruptDemo;
import org.classesForTheBankScenarios_Interupt.InteruptDemoAdvanced;
import org.classesForTheBankScenarios_Interupt.InteruptDemoAdvanced2;

public class Interupt {
	
	public static void Interupt_Working() {
		
		InteruptDemo bm = new InteruptDemo();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				bm.withdraw(1000);
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				if(bm.deposit(2000)) {
					System.out.println("Transcation Completed");
				}else {
					thread1.interrupt();
				}
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void Interupt_Working_Advanced() {
		
		InteruptDemoAdvanced bm = new InteruptDemoAdvanced();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				bm.withdraw(1000);
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				if(bm.deposit(2000)) {
					System.out.println("Transcation Completed");
				}else {
					thread1.interrupt();
				}
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void Interupt_Working_ZeroValue() {
		
		InteruptDemoAdvanced bm = new InteruptDemoAdvanced();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				bm.withdraw(1000);
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				if(bm.deposit(0)) {
					System.out.println("Transcation Completed");
				}else {
					thread1.interrupt();
				}
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void Interupt_Working_500Value() {
	
		InteruptDemoAdvanced bm = new InteruptDemoAdvanced();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				bm.withdraw(1000);
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				if(bm.deposit(500)) {
					System.out.println("Transcation Completed");
				}else {
					thread1.interrupt();
				}
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void Interupt_Working_SlightCodeChange() {
		
		InteruptDemoAdvanced2 bm = new InteruptDemoAdvanced2();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				bm.withdraw(1000);
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				if(bm.deposit(500)) {
					System.out.println("Transcation Completed");
				}else {
					thread1.interrupt();
				}
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
}
