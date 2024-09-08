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
				//Working of a Thread Demo/ Thread Introduction
				Thread_Intro.ThreadIntro();
				break;
			case 2:
				//Working of a Thread Demo_With Another Counter
				Thread_Intro.ThreadIntro_AnotherCounter();
				break;
			case 3:
				//Thread.sleep() //returns also InterruptedException
				Thread_Intro.ThreadIntro_Sleep();
				break;
			case 4:
				//ThreadIntro_CurrentTimeMilliSeconds 
				//10 seconds - 10113
				//This is fully synchronized but we have to do multithreaded
				Thread_Intro.ThreadIntro_CurrentTimeMilliSeconds();
				break;
			case 5:
				//Thread Intro With Thread Class
				//Not Mulithreading  - Concurrently run applications
				Thread_Intro.Thread_ClassThread();
				break;
			case 6:
				//Using Thread.start() and making it multithreaded
				Thread_Intro.Thread_ClassThread_Start();
				break;
			case 7:
				//Using Thread.start() and sleep and making it multithreaded
				Thread_Intro.Thread_ClassThread_Start_With_Sleep();
				break;
			case 8:
				//Using Thread.start() and sleep and making it multithreaded adding
				//one more thread
				Thread_Intro.Thread_ClassThread_Start_With_Sleep_With_OneMoreThread();
				break;
			case 9:
				//Using Thread.start() and sleep and making it multithreaded adding
				//one more thread with change in value of sleep
				Thread_Intro.Thread_ClassThread_Start_With_Sleep_With_OneMoreThread_With_ChangeInSleepValue();
				break;
			}
		sc.close();
	}

}
