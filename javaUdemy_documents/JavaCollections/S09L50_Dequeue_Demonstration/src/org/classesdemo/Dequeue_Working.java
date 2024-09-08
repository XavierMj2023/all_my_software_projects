package org.classesdemo;

import java.util.Deque;
import java.util.concurrent.LinkedBlockingDeque;

public class Dequeue_Working {
	
	public static void DequeueWorking() {
		
		System.out.println("--------Working of Dequeue-------");
		
		Deque<Integer> deque = new LinkedBlockingDeque<>();
		System.out.println(deque.poll());
		deque.offer(1);
		deque.offer(2);
		deque.offer(3);
		deque.offer(4);
		deque.offer(5);
		
		System.out.println(deque);
		
		System.out.println("----------------------------------");
	}
}
