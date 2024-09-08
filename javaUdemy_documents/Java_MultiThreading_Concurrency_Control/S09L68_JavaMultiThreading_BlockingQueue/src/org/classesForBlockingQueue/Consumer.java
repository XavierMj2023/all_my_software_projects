package org.classesForBlockingQueue;

import java.util.concurrent.ArrayBlockingQueue;

import org.BlockingQueue_Intro;

public class Consumer implements Runnable{

	private ArrayBlockingQueue<Integer> queue;

	public Consumer(ArrayBlockingQueue<Integer> queue) {
		this.queue = queue;
	}

	@Override
	public void run() {
		//Infinite Loop
		while(true) {
			try {
				Thread.sleep(1500);
				queue.take();
				System.out.println("Value removed from the queue : "+BlockingQueue_Intro.counter);
				BlockingQueue_Intro.counter--;
			} catch (InterruptedException e) {
				
				e.printStackTrace();
			}
		}
	}
	
	
}
