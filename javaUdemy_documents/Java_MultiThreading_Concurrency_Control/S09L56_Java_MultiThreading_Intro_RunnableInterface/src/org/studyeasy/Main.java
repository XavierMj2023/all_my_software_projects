package org.studyeasy;

import java.util.Scanner;

import org.threaddata.Thread_Intro;

public class Main {

	public static void main(String[] args) throws InterruptedException {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				// ThreadIntro_Runnable Interface
				Thread_Intro.Thread_Class_RunnableInterface();
				break;
			case 2:
				// ThreadIntro_Runnable Interface Randomize Sleep
				Thread_Intro.Thread_Class_RunnableInterface_RandomizeSleep();
				break;
			case 3:
				// ThreadIntro_Runnable Interface Anonymous Class
				Thread_Intro.Thread_Class_RunnableInterface_AnonymousClass();
				break;
			case 4:
				//Micro Thread
				//As soon as last line executation, the thread dies soon.
				Thread_Intro.Thread_Class_RunnableInterface_AnonymousClass_MicroThread();
				break;
			}
		sc.close();
	}

}
