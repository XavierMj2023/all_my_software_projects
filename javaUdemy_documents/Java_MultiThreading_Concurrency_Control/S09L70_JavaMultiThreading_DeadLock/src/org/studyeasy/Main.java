package org.studyeasy;

import java.util.Scanner;

import org.DeadLockResources.DeadLock_Intro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Deadlock introduction
			/*
			 * Deadlock is a scenario where thread is holding a resource, but resource is required by some other thread and vice 
			 * versa. 
			 * 
			 * If there is a intersection or holding of resources, then there will be a Deadlock.
			 */
			try {
				DeadLock_Intro.DeadLock();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 2:
			//DeadLock Part 2
			try {
				DeadLock_Intro.DeadLock_Intersection();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 3:
			//DeadLock Mimicing some processing
			try {
				DeadLock_Intro.DeadLock_MimicSomeProcessing();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 4:
			//DeadLock using TryCatch
			try {
				DeadLock_Intro.DeadLock_TryCatch();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 5:
			//DeadLock using TryCatch with change in sequence
			try {
				DeadLock_Intro.DeadLock_TryCatch_ChangeSequence();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 6:
			//DeadLock TryLock
			try {
				DeadLock_Intro.DeadLock_TryCatch_TryLock();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		}
		sc.close();
	}
}