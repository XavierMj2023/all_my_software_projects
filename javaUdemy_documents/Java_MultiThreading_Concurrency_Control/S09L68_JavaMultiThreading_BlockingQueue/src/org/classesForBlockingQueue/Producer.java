package org.classesForBlockingQueue;

import java.util.concurrent.ArrayBlockingQueue;

import org.BlockingQueue_Intro;

public class Producer implements Runnable{

	private ArrayBlockingQueue<Integer> queue;

	public Producer(ArrayBlockingQueue<Integer> queue) {
		this.queue = queue;
	}

	@Override
	public void run() {
		//Infinite Loop
		while(true) {
			try {
				Thread.sleep(1000);
				queue.put(BlockingQueue_Intro.counter);
				System.out.println("Value added in the queue : "+BlockingQueue_Intro.counter);
				BlockingQueue_Intro.counter++;
			} catch (InterruptedException e) {
				
				e.printStackTrace();
			}
		}
	}
	
	
}
