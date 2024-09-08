package org.studyeasy;

import java.util.Scanner;

import org.waitAndnotify_classes.WaitAndNotifyIntro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Try to mimic scenario where app is waiting until deposit of money has happened and then only withdrawal
				//method is called.
				//Wait and Notify Intro
				WaitAndNotifyIntro.WaitAndNotifyIntroExe();
				break;
			case 2:
				//When we are making use of wait and notify, we have to make use of synchronized block
				//Withdraw method as synchronized
				//Wait
				WaitAndNotifyIntro.WaitAndNotifyIntroExe_Synchronized();
				break;
			case 3:
				//No value entered in wait()
				//It will keep on waiting for a long time and executation is paused or onhold
				//We can fix this by notifying
				WaitAndNotifyIntro.WaitAndNotifyIntroExe_Synchronized_With_No_WaitValue();
				break;
			case 4:
				//As soon as the balance updated, wait lock should be released.
				//Notify
				//2 places where we can call notify().
				//either after this particular call to the deposit method or inside the deposit method directly.
				
				//Case 1: Inside deposit method directly
				//Notify     - notify just the longest waiting thread.
				//NotifyAll  - notify will release all of the waiting threads
				WaitAndNotifyIntro.WaitAndNotifyIntroExe_Synchronized_With_Notify();
				break;
			}
		sc.close();
	}

}
