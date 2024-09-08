package org.waitAndnotify_classes;

import org.classesForTheBankScenarios.BankMethods;
import org.classesForTheBankScenarios.BankMethods_With_Synchronized;
import org.classesForTheBankScenarios.BankMethods_With_Synchronized_NoWaitValue;
import org.classesForTheBankScenarios.BankMethods_With_Synchronized_Notify;

public class WaitAndNotifyIntro {
	
	public static void WaitAndNotifyIntroExe() {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods bm = new BankMethods();
				try {
					bm.withdraw(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods bm = new BankMethods();
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				bm.deposit(2000);
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void WaitAndNotifyIntroExe_Synchronized() {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods_With_Synchronized bm = new BankMethods_With_Synchronized();
				try {
					bm.withdraw(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods_With_Synchronized bm = new BankMethods_With_Synchronized();
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				bm.deposit(2000);
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void WaitAndNotifyIntroExe_Synchronized_With_No_WaitValue() {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods_With_Synchronized_NoWaitValue bm = new BankMethods_With_Synchronized_NoWaitValue();
				try {
					bm.withdraw(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
		});
		thread1.setName("Thread 1");
		thread1.start();
		
		
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				BankMethods_With_Synchronized_NoWaitValue bm = new BankMethods_With_Synchronized_NoWaitValue();
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				bm.deposit(2000);
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
	public static void WaitAndNotifyIntroExe_Synchronized_With_Notify() {
		
		BankMethods_With_Synchronized_Notify bm = new BankMethods_With_Synchronized_Notify();
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					bm.withdraw(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
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
				bm.deposit(2000);
			}
		});
		thread2.setName("Thread 2");
		thread2.start();
	}
}
