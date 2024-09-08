package org.studyeasy;

import java.util.Queue;
import java.util.concurrent.LinkedBlockingQueue;

public class Main {

	public static void main(String[] args) {
		Queue<Integer> queque = new LinkedBlockingQueue<>(5);
		try {
			queque.add(1);
			queque.add(2);
			queque.add(3);
			queque.add(4);
			queque.add(5);
			queque.add(6);
			queque.remove();//6 has been removed
			queque.add(7);
			
			//queque.add(null); <- You get error
		}catch(Exception e) {
			System.out.println("Something went wrong");
		}
		
		System.out.println(queque);
		
		//Case 2 - using offer() instead of add()/remove()
		Queue<Integer> queque2 = new LinkedBlockingQueue<>(5);
		try {
			queque2.offer(1);
			queque2.offer(2);
			queque2.offer(3);
			queque2.offer(4);
			queque2.offer(5);
			queque2.offer(6);
			queque2.remove();
			queque2.offer(7);
		}catch(Exception e) {
			System.out.println("Something went wrong");
		}
		
		System.out.println(queque2);
		
		//Case 3 - printing that special value
		Queue<Integer> queque3 = new LinkedBlockingQueue<>(5);
		try {
			queque3.offer(1);
			queque3.offer(2);
			queque3.offer(3);
			queque3.offer(4);
			queque3.offer(5);
			//queque3.offer(6);
			System.out.println(queque3.offer(6));
			queque3.remove();
			queque3.offer(7);
		}catch(Exception e) {
			System.out.println("Something went wrong");
		}
				
		System.out.println(queque3);
		
		//Case 4 - Using poll() and remove() at the begining of the declaration 
		//         of the queue.
		System.out.println("-------Case 4-------------------");
		Queue<Integer> queque4 = new LinkedBlockingQueue<>(5);
		//System.out.println(queque4.remove());//Exception
		System.out.println(queque4.poll());//null
		try {
			queque4.offer(1);
			queque4.offer(2);
			queque4.offer(3);
			queque4.offer(4);
			queque4.offer(5);
			//queque3.offer(6);
			System.out.println(queque4.offer(6));//false
			System.out.println(queque4.poll());//1
			//queque4.remove();
			queque4.offer(7);
		}catch(Exception e) {
			System.out.println("Something went wrong");
		}
				
		System.out.println(queque4.peek());
		System.out.println(queque4.element());
		System.out.println(queque4);
	}

}
