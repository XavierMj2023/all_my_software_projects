package org.studyeasy;

import java.util.Scanner;

import org.classesdemo.Dequeue_Working;
import org.classesdemo.Dequeue_Working_addFirst_and_removeLast;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Working of Deque
			Dequeue_Working.DequeueWorking();
		case 2:
			//Working of Deque with addFirst and removeLast
			Dequeue_Working_addFirst_and_removeLast.DequeueWorking();
		}
		sc.close();
	}

}
