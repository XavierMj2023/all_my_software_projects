package org.studyeasy;

import java.util.Scanner;

import org.studclasses.ReentrantLockDemo;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Reentrant Lock Intro
			//The final output is not consistent.
			try {
				ReentrantLockDemo.ReentrantLockExe();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 2:
			//Locking and Unlocking is an Intinisive mechanism operation
			//Solution is to bring lock outside the for loop and also inlock after the loop completion.
			try {
				ReentrantLockDemo.ReentrantLockExe_Sol();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 3:
			//Solution is to bring lock outside the for loop and also inlock after the loop completion.
			//Lock and unlock are made for each other, else the resource will be locked.
			try {
				ReentrantLockDemo.ReentrantLockExe_ChangesInForLoop();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		case 4:
			//Try Catch Block
			try {
				ReentrantLockDemo.ReentrantLockExe_TryCatchBlock();
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			break;
		}
		sc.close();
	}
}
