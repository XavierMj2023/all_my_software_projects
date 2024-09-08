package org.DeadLockResources;

import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

public class DeadLock_Intro {

	public static void DeadLock() throws InterruptedException {
		
		String lock1 ="lock1";
		String lock2 ="lock2";
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock1) {
					System.out.println("Thread1, Lock1");
					synchronized (lock2) {
						System.out.println("Thread1, Lock2");
					}
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock1) {
					System.out.println("Thread2, Lock1");
					synchronized (lock2) {
						System.out.println("Thread2, Lock2");
					}
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
	public static void DeadLock_Intersection() throws InterruptedException {
		
		String lock1 ="lock1";
		String lock2 ="lock2";
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock1) {
					System.out.println("Thread1, Lock1");
					synchronized (lock2) {
						System.out.println("Thread1, Lock2");
					}
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock2) {
					System.out.println("Thread2, Lock2");
					synchronized (lock1) {
						System.out.println("Thread2, Lock1");
					}
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
	public static void DeadLock_MimicSomeProcessing() throws InterruptedException {
		
		String lock1 ="lock1";
		String lock2 ="lock2";
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock1) {
					try {
						Thread.sleep(10);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					System.out.println("Thread1, Lock1");
					synchronized (lock2) {
						System.out.println("Thread1, Lock2");
					}
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				synchronized (lock2) {
					try {
						Thread.sleep(10);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					System.out.println("Thread2, Lock2");
					synchronized (lock1) {
						System.out.println("Thread2, Lock1");
					}
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
	
	static Lock lock_new_1 = new ReentrantLock();
	static Lock lock_new_2 = new ReentrantLock();
	
	public static void DeadLock_TryCatch() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock_new_1.lock();
				System.out.println("Thread 1 , Lock 1");
				lock_new_2.lock();
				System.out.println("Thread 1 , Lock 2");
				lock_new_2.unlock();
				lock_new_1.unlock();
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock_new_1.lock();
				System.out.println("Thread 2 , Lock 1");
				lock_new_2.lock();
				System.out.println("Thread 2 , Lock 2");
				lock_new_2.unlock();
				lock_new_1.unlock();
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
	
	public static void DeadLock_TryCatch_ChangeSequence() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock_new_1.lock();
				System.out.println("Thread 1 , Lock 1");
				lock_new_2.lock();
				System.out.println("Thread 1 , Lock 2");
				lock_new_2.unlock();
				lock_new_1.unlock();
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock_new_2.lock();
				System.out.println("Thread 2 , Lock 1");
				lock_new_1.lock();
				System.out.println("Thread 2 , Lock 2");
				lock_new_1.unlock();
				lock_new_2.unlock();
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
	public static void DeadLock_TryCatch_TryLock() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				boolean flaglock01 = false;
				boolean flaglock02 = false;
				while(true) {
					try {
						flaglock01 = lock_new_1.tryLock(10,TimeUnit.MILLISECONDS);
						flaglock02 = lock_new_2.tryLock(10,TimeUnit.MILLISECONDS);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}finally {
						if(flaglock01) {
							System.out.println("Thread1, Lock1");
							lock_new_1.unlock();
						}
						if(flaglock02) {
							System.out.println("Thread1, Lock2");
							lock_new_2.unlock();
						}
						if(flaglock01 && flaglock02) {
							break;
						}
					}
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				boolean flaglock01 = false;
				boolean flaglock02 = false;
				while(true) {
					try {
						flaglock02 = lock_new_2.tryLock(10,TimeUnit.MILLISECONDS);
						flaglock01 = lock_new_1.tryLock(10,TimeUnit.MILLISECONDS);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}finally {
						if(flaglock02) {
							System.out.println("Thread2, Lock2");
							lock_new_2.unlock();
						}
						if(flaglock01) {
							System.out.println("Thread2, Lock1");
							lock_new_1.unlock();
						}
						if(flaglock01 && flaglock02) {
							break;
						}
					}
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Main Thread");
	}
}
