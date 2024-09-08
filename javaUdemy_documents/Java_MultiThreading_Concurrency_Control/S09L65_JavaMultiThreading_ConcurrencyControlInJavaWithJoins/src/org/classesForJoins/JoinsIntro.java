package org.classesForJoins;

public class JoinsIntro {
	
	public static int counter1 = 0;
	
	public static int counter2 = 0;

	public static void JoinsIntroExe() {
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					counter1++;
				}
			}
		});
		thread1.start();
		System.out.println("Counter1 : "+counter1);
	}
	public static void JoinsIntroExe_Sleep() throws InterruptedException {
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					counter1++;
				}
			}
		});
		thread1.start();
		Thread.sleep(1000);
		System.out.println("Counter1 : "+counter1);
	}
	public static void JoinsIntroExe_JoinMethod() throws InterruptedException {
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					counter1++;
				}
			}
		});
		thread1.start();
		thread1.join();
		System.out.println("Counter1 : "+counter1);
	}
	public static void JoinsIntroExe_JoinMethod_AnotherWay1() throws InterruptedException {
		
		//Working on a Thread 1
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter1++;
				}
			}
		});
		thread1.start();
		
		//Working on a Thread 2
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter2++;
				}
			}
		});
		thread2.start();
		
		//Waiting for thread1 and thread 2 to complete
		Thread thread3 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					thread1.join();
					thread2.join();
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				
				System.out.println("Counter1 : "+counter1);
				System.out.println("Counter2 : "+counter2);
			}
		});
		thread3.start();
		
		System.out.println("Main Thread!.. : "+Thread.currentThread().getName());
	}
	public static void JoinsIntroExe_JoinMethod_CommentingOutThread1() throws InterruptedException {
		
		//Working on a Thread 1
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter1++;
				}
			}
		});
		thread1.start();
		
		//Working on a Thread 2
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter2++;
				}
			}
		});
		thread2.start();
		
		//Waiting for thread1 and thread 2 to complete
		Thread thread3 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					//thread1.join();
					thread2.join();
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				
				System.out.println("Counter1 : "+counter1);
				System.out.println("Counter2 : "+counter2);
			}
		});
		thread3.start();
		
		System.out.println("Main Thread!.. : "+Thread.currentThread().getName());
	}
	public static void JoinsIntroExe_JoinMethod_CommentingInsideThread3() throws InterruptedException {
		
		//Working on a Thread 1
		Thread thread1 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter1++;
				}
			}
		});
		thread1.start();
		
		//Working on a Thread 2
		Thread thread2 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				for (int i = 0; i < 1000; i++) {
					try {
						Thread.sleep(1);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
					counter2++;
				}
			}
		});
		thread2.start();
		
		//Waiting for thread1 and thread 2 to complete
		Thread thread3 = new Thread(new Runnable() {
			
			@Override
			public void run() {
				/*
				 * try { thread1.join(); thread2.join(); } catch (InterruptedException e) {
				 * e.printStackTrace(); }
				 */
				
				System.out.println("Counter1 : "+counter1);
				System.out.println("Counter2 : "+counter2);
			}
		});
		thread3.start();
		
		System.out.println("Main Thread!.. : "+Thread.currentThread().getName());
	}
}
