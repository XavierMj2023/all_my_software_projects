package org.studyeasy;

import java.util.Scanner;

import org.classesForJoins.JoinsIntro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Java MultiThreading_ConcurrencyControl In Java With Joins
				//Joins will enable us to bring a synchronization between threads
				JoinsIntro.JoinsIntroExe();
				break;
			case 2:
				//Joins with sleep
			try {
				JoinsIntro.JoinsIntroExe_Sleep();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
				break;
			case 3:
				//Join()
			try {
				JoinsIntro.JoinsIntroExe_JoinMethod();
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
				break;
			case 4:
				//Main Thread ; 3 Threads
				//Thread 3 will be waiting parallely the Thread 1 and 2 will be executing
			try {
				JoinsIntro.JoinsIntroExe_JoinMethod_AnotherWay1();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
				break;
			case 5:
				//Commenting out the Thread 1.join() in Thread 3 and we get weird output.
			try {
				JoinsIntro.JoinsIntroExe_JoinMethod_CommentingOutThread1();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
				break;
			case 6:
				//Commenting inside the Thread 3 and we do not get updated output.
			try {
				JoinsIntro.JoinsIntroExe_JoinMethod_CommentingInsideThread3();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
				break;
		}
		sc.close();
	}
}