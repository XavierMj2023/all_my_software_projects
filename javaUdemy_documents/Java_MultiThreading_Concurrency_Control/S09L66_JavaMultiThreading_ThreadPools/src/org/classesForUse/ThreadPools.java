package org.classesForUse;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import org.classesForThreads.SomeThread;

public class ThreadPools {
	
	public static void ThreadPoolsIntro() {
		
		SomeThread thread01 = new SomeThread("Thread01");
		thread01.start();
	}
	public static void ThreadPool_TonOfThreads() {
		
		SomeThread thread01 = new SomeThread("Thread01");
		SomeThread thread02 = new SomeThread("Thread02");
		SomeThread thread03 = new SomeThread("Thread03");
		SomeThread thread04 = new SomeThread("Thread04");
		SomeThread thread05 = new SomeThread("Thread05");
		SomeThread thread06 = new SomeThread("Thread06");
		SomeThread thread07 = new SomeThread("Thread07");
		SomeThread thread08 = new SomeThread("Thread08");
		SomeThread thread09 = new SomeThread("Thread09");
		SomeThread thread10 = new SomeThread("Thread10");
		SomeThread thread11 = new SomeThread("Thread11");
		SomeThread thread12 = new SomeThread("Thread12");
		thread01.start();
		thread02.start();
		thread03.start();
		thread04.start();
		thread05.start();
		thread06.start();
		thread07.start();
		thread08.start();
		thread09.start();
		thread10.start();
		thread11.start();
		thread12.start();
	}
	public static void ThreadPool_ExecutorService() {
		
		ExecutorService executorService = Executors.newFixedThreadPool(6);
		
		SomeThread thread01 = new SomeThread("Thread01");
		SomeThread thread02 = new SomeThread("Thread02");
		SomeThread thread03 = new SomeThread("Thread03");
		SomeThread thread04 = new SomeThread("Thread04");
		SomeThread thread05 = new SomeThread("Thread05");
		SomeThread thread06 = new SomeThread("Thread06");
		SomeThread thread07 = new SomeThread("Thread07");
		SomeThread thread08 = new SomeThread("Thread08");
		SomeThread thread09 = new SomeThread("Thread09");
		SomeThread thread10 = new SomeThread("Thread10");
		SomeThread thread11 = new SomeThread("Thread11");
		SomeThread thread12 = new SomeThread("Thread12");
		
		//executorService.execute(thread01);
		
		executorService.execute(thread01);
		executorService.execute(thread02);
		executorService.execute(thread03);
		executorService.execute(thread04);
		executorService.execute(thread05);
		executorService.execute(thread06);
		executorService.execute(thread07);
		executorService.execute(thread08);
		executorService.execute(thread09);
		executorService.execute(thread10);
		executorService.execute(thread11);
		executorService.execute(thread12);
	}
	public static void ThreadPool_ExecutorService_ShutDown() {
		
		ExecutorService executorService = Executors.newFixedThreadPool(6);
		
		SomeThread thread01 = new SomeThread("Thread01");
		SomeThread thread02 = new SomeThread("Thread02");
		SomeThread thread03 = new SomeThread("Thread03");
		SomeThread thread04 = new SomeThread("Thread04");
		SomeThread thread05 = new SomeThread("Thread05");
		SomeThread thread06 = new SomeThread("Thread06");
		SomeThread thread07 = new SomeThread("Thread07");
		SomeThread thread08 = new SomeThread("Thread08");
		SomeThread thread09 = new SomeThread("Thread09");
		SomeThread thread10 = new SomeThread("Thread10");
		SomeThread thread11 = new SomeThread("Thread11");
		SomeThread thread12 = new SomeThread("Thread12");
		
		//executorService.execute(thread01);
		
		executorService.execute(thread01);
		executorService.execute(thread02);
		executorService.execute(thread03);
		executorService.execute(thread04);
		executorService.execute(thread05);
		executorService.execute(thread06);
		executorService.execute(thread07);
		executorService.execute(thread08);
		executorService.execute(thread09);
		executorService.execute(thread10);
		executorService.execute(thread11);
		executorService.execute(thread12);
		
		executorService.shutdown();
	}
}
