package org.CountDownLatchProgram;

import java.util.concurrent.CountDownLatch;

import org.classesForThreads.SomeThread;
import org.classesForThreads.SomeThread_CountDownLatch_Reference;
import org.classesForThreads.SomeThread_CountDownLatch_Release;

public class CountDownLatch_Intro {

	public static void CountDownLatch_Exe() {
		
		SomeThread thread1 = new SomeThread();
		thread1.start();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Ref() {
		
		CountDownLatch latch = new CountDownLatch(4);
		SomeThread_CountDownLatch_Reference thread1 = new SomeThread_CountDownLatch_Reference(latch);
		thread1.start();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Await() throws InterruptedException {
		
		CountDownLatch latch = new CountDownLatch(4);
		SomeThread_CountDownLatch_Reference thread1 = new SomeThread_CountDownLatch_Reference(latch);
		thread1.start();
		
		latch.await();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Call4Times() throws InterruptedException {
		
		CountDownLatch latch = new CountDownLatch(4);
		SomeThread_CountDownLatch_Reference thread1 = new SomeThread_CountDownLatch_Reference(latch);
		SomeThread_CountDownLatch_Reference thread2 = new SomeThread_CountDownLatch_Reference(latch);
		SomeThread_CountDownLatch_Reference thread3 = new SomeThread_CountDownLatch_Reference(latch);
		SomeThread_CountDownLatch_Reference thread4 = new SomeThread_CountDownLatch_Reference(latch);
		thread1.start();
		thread2.start();
		thread3.start();
		thread4.start();
		
		latch.await();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Release() throws InterruptedException {
		
		CountDownLatch latch = new CountDownLatch(4);
		SomeThread_CountDownLatch_Release thread1 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread2 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread3 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread4 = new SomeThread_CountDownLatch_Release(latch);
		thread1.start();
		thread2.start();
		thread3.start();
		thread4.start();
		
		latch.await();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Release_Less() throws InterruptedException {
		
		CountDownLatch latch = new CountDownLatch(3);
		SomeThread_CountDownLatch_Release thread1 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread2 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread3 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread4 = new SomeThread_CountDownLatch_Release(latch);
		thread1.start();
		thread2.start();
		thread3.start();
		thread4.start();
		
		latch.await();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
	public static void CountDownLatch_CountDownLatch_Release_Less_5() throws InterruptedException {
		
		CountDownLatch latch = new CountDownLatch(5);
		SomeThread_CountDownLatch_Release thread1 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread2 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread3 = new SomeThread_CountDownLatch_Release(latch);
		SomeThread_CountDownLatch_Release thread4 = new SomeThread_CountDownLatch_Release(latch);
		thread1.start();
		thread2.start();
		thread3.start();
		thread4.start();
		
		latch.await();
		System.out.println("Main Thread: "+Thread.currentThread().getName());
	}
}
