package org.studyeasy;

import java.util.Scanner;

import org.CountDownLatchProgram.CountDownLatch_Intro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Count Down Latch Intro
			CountDownLatch_Intro.CountDownLatch_Exe();
			break;
		case 2:
			//CountDownLatch Executation
			CountDownLatch_Intro.CountDownLatch_CountDownLatch_Ref();
			break;
		case 3:
			//CountDownLatch Await
			//App continues executing and does not stop. Why?
			//A Latch is nothing but a lock system. 
			try {
				CountDownLatch_Intro.CountDownLatch_CountDownLatch_Await();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 4:
			//4 Threads are used here
			try {
				CountDownLatch_Intro.CountDownLatch_CountDownLatch_Call4Times();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 5:
			//4 Threads are used here - Release
			try {
				CountDownLatch_Intro.CountDownLatch_CountDownLatch_Release();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 6:
			//The number of CountDownLatches are less than the times we have called in countdown method
			try {
				CountDownLatch_Intro.CountDownLatch_CountDownLatch_Release_Less();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 7:
			//The number of CountDownLatches are less than the times we have called in countdown method ; 5
			try {
				CountDownLatch_Intro.CountDownLatch_CountDownLatch_Release_Less_5();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		}
		sc.close();
	}

}
