package org.studclasses;

import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

public class ReentrantLockDemo {
	
	public static int counter = 0;
	
	static Lock lock = new ReentrantLock();
	
	public static void ReentrantLockExe() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 100000; i++) {
					ReentrantLockDemo.counter++;
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 100000; i++) {
					ReentrantLockDemo.counter++;
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Counter: "+ReentrantLockDemo.counter);
	}
	public static void ReentrantLockExe_Sol() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 100000; i++) {
					lock.lock();
					ReentrantLockDemo.counter++;
					lock.unlock();
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 100000; i++) {
					lock.lock();
					ReentrantLockDemo.counter++;
					lock.unlock();
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Counter: "+ReentrantLockDemo.counter);
	}
	public static void ReentrantLockExe_ChangesInForLoop() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock.lock();
				for(int i = 0; i < 100000; i++) {
					ReentrantLockDemo.counter++;
				}
				lock.unlock();
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock.lock();
				for(int i = 0; i < 100000; i++) {
					ReentrantLockDemo.counter++;
				}
				lock.unlock();
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Counter: "+ReentrantLockDemo.counter);
	}
	public static void ReentrantLockExe_TryCatchBlock() throws InterruptedException {
		
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock.lock();
				try {
					for(int i = 0; i < 100000; i++) {
						ReentrantLockDemo.counter++;
					}
				}finally {
					lock.unlock();
				}
			}
		});
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				lock.lock();
				try {
					for(int i = 0; i < 100000; i++) {
						ReentrantLockDemo.counter++;
					}
				}finally {
					lock.unlock();
				}
			}
		});
		thread1.start();
		thread2.start();
		thread1.join();
		thread2.join();
		System.out.println("Counter: "+ReentrantLockDemo.counter);
	}
}
