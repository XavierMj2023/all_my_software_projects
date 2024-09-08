package org;

import java.util.concurrent.ArrayBlockingQueue;

import org.classesForBlockingQueue.Consumer;
import org.classesForBlockingQueue.Producer;

public class BlockingQueue_Intro {

	public static int counter = 1;
	
	public static void BlockingQueue_Exe_Producer() {
		
		ArrayBlockingQueue<Integer> queue = new ArrayBlockingQueue<>(10);
		Thread thread1 = new Thread(new Producer(queue));
		thread1.start();
	}
	public static void BlockingQueue_Exe_Consumer() {
		
		ArrayBlockingQueue<Integer> queue = new ArrayBlockingQueue<>(10);
		Thread thread1 = new Thread(new Producer(queue));
		thread1.start();
		Thread thread2 = new Thread(new Consumer(queue));
		thread2.start();
	}
}
