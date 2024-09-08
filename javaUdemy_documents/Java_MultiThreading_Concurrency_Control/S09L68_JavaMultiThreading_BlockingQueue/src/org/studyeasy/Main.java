package org.studyeasy;

import java.util.Scanner;

import org.BlockingQueue_Intro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Blocking Queue Intro
			//Producer Class architecture
			BlockingQueue_Intro.BlockingQueue_Exe_Producer();
			break;
		case 2:
			//Blocking Queue Intro
			//Consumer Class architecture
			BlockingQueue_Intro.BlockingQueue_Exe_Consumer();
			break;
		}
	}

}
