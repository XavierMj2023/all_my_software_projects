package org.lambdaexpression;

import org.interfaces.Lambda_MultipleMethods;

public class LambdaThread {

	public static void LambdaThread_MultipleMethodsInInterface_SameMethod() {
		
		Lambda_MultipleMethods lambda = (() -> System.out.println("Statement 02"));
		
		lambda.demo();
	}
	public static void LambdaThread_MultipleMethodsInInterface_Thread() {
		
		Thread thread = new Thread(new Runnable() {
			
			@Override
			public void run() {
				System.out.println("Statement 01");
			}
		});
		thread.start();
		
		//Simplified version of Thread and Lambda
		Thread thread2 = new Thread(()-> System.out.println("Simplified version of Thread and Lambda"));
		thread2.start();
	}
	public static void LambdaThread_MultipleMethodsInInterface_SimplifiedThread() {
		
		//Previous way was
		Thread thread45a = new Thread(new Runnable() {
			
			@Override
			public void run() {
				System.out.println("Statement 01");
			}
		});
		thread45a.start();
		
		//Simplified version of above with different variable name
		//They are part of run()
		Thread thread45 = new Thread(()-> {
			System.out.println("Statement 01");
			System.out.println("Statement 02");
		});
		thread45.start();
		
		
	}
}
