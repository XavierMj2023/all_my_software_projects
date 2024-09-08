package org.studyeasy;

import java.util.Scanner;

import org.classesForUse.ThreadPools;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Thread Pools Intro
				ThreadPools.ThreadPoolsIntro();
				break;
			case 2:
				//You may have ton of threads. 
				ThreadPools.ThreadPool_TonOfThreads();
				break;
			case 3:
				//There is a physical limit when it comes to the processor.
				//Schedule the thread properly.
				//Executor Service
				//Optimized application
				//But it has not stop executing. Reason is shut down ExecutorService
				ThreadPools.ThreadPool_ExecutorService();
				break;
			case 4:
				//shut down ExecutorService
				ThreadPools.ThreadPool_ExecutorService_ShutDown();
				break;
		}
		sc.close();
	}
}