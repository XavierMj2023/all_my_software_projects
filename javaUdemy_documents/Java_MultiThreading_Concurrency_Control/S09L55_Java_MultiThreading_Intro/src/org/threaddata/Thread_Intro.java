package org.threaddata;

import org.classWhichWeUseForSomePurpose.MyCounter;
import org.classWhichWeUseForSomePurpose.MyCounterExtendsThreadClass;
import org.classWhichWeUseForSomePurpose.MyCounterUpdated;
import static java.lang.Thread.sleep;

public class Thread_Intro {
	
	public static void ThreadIntro() {
		MyCounter counter1 = new MyCounter(1);
		counter1.countMe();
	}
	public static void ThreadIntro_AnotherCounter() {
		MyCounter counter1 = new MyCounter(1);
		MyCounter counter2 = new MyCounter(2);
		counter1.countMe();
		System.out.println("****************************");
		counter2.countMe();
	}
	public static void ThreadIntro_Sleep() throws InterruptedException{
		MyCounterUpdated counter1 = new MyCounterUpdated(1);
		MyCounterUpdated counter2 = new MyCounterUpdated(2);
		counter1.countMe();
		System.out.println("****************************");
		counter2.countMe();
	}
	public static void ThreadIntro_CurrentTimeMilliSeconds() throws InterruptedException{
		MyCounterUpdated counter1 = new MyCounterUpdated(1);
		MyCounterUpdated counter2 = new MyCounterUpdated(2);
		long startTime = System.currentTimeMillis();
		counter1.countMe();
		System.out.println("****************************");
		counter2.countMe();
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
	public static void Thread_ClassThread() throws InterruptedException{
		MyCounterExtendsThreadClass counter1 = new MyCounterExtendsThreadClass(1);
		MyCounterExtendsThreadClass counter2 = new MyCounterExtendsThreadClass(2);
		long startTime = System.currentTimeMillis();
		counter1.run();
		System.out.println("****************************");
		counter2.run();
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
	public static void Thread_ClassThread_Start() throws InterruptedException{
		MyCounterExtendsThreadClass counter1 = new MyCounterExtendsThreadClass(1);
		MyCounterExtendsThreadClass counter2 = new MyCounterExtendsThreadClass(2);
		long startTime = System.currentTimeMillis();
		counter1.start();
		System.out.println("****************************");
		counter2.start();
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
	public static void Thread_ClassThread_Start_With_Sleep() throws InterruptedException{
		MyCounterExtendsThreadClass counter1 = new MyCounterExtendsThreadClass(1);
		MyCounterExtendsThreadClass counter2 = new MyCounterExtendsThreadClass(2);
		long startTime = System.currentTimeMillis();
		counter1.start();
		System.out.println("****************************");
		counter2.start();
		sleep(6000);
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
	public static void Thread_ClassThread_Start_With_Sleep_With_OneMoreThread() throws InterruptedException{
		MyCounterExtendsThreadClass counter1 = new MyCounterExtendsThreadClass(1);
		MyCounterExtendsThreadClass counter2 = new MyCounterExtendsThreadClass(2);
		MyCounterExtendsThreadClass counter3 = new MyCounterExtendsThreadClass(3);
		long startTime = System.currentTimeMillis();
		counter1.start();
		System.out.println("****************************");
		counter2.start();
		counter3.start();
		sleep(6000);
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
	public static void Thread_ClassThread_Start_With_Sleep_With_OneMoreThread_With_ChangeInSleepValue() throws InterruptedException{
		MyCounterExtendsThreadClass counter1 = new MyCounterExtendsThreadClass(1);
		MyCounterExtendsThreadClass counter2 = new MyCounterExtendsThreadClass(2);
		MyCounterExtendsThreadClass counter3 = new MyCounterExtendsThreadClass(3);
		long startTime = System.currentTimeMillis();
		counter1.start();
		System.out.println("****************************");
		counter2.start();
		counter3.start();
		sleep(5100);
		long endTime = System.currentTimeMillis();
		System.out.println("Total Time required for processing : "+(endTime - startTime));
	}
}
