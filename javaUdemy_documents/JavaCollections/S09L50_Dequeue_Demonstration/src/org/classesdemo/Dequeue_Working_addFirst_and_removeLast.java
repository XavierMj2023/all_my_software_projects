package org.classesdemo;

import java.util.Deque;
import java.util.concurrent.LinkedBlockingDeque;

public class Dequeue_Working_addFirst_and_removeLast {
	
public static void DequeueWorking() {
		
		System.out.println("--------Working of Dequeue addFirst and removeLast-------");
		
		Deque<Integer> deque = new LinkedBlockingDeque<>();
		deque.offer(1);
		deque.offer(2);
		deque.offer(3);
		deque.offer(4);
		deque.offer(5);
		System.out.println(deque);
		
		deque.addFirst(0);
		deque.removeLast();
		System.out.println(deque);
		
		System.out.println("----------------------------------");
	}
}
