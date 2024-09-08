package org.classesForUse;

public class VolatileIntro {
	
	public static int flag = 0;
	
	volatile public static int flag2 = 0;
	
	public static void VolatileExecutation() {
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				int i = 0;
				//Infinite Loop
				while(true) {
					if(flag == 0) {
						System.out.println(i + " : Running...");
						i++;
					}
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(100);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				flag = 1;
				System.out.println("The value of the flag updated and thread 1 stopped");
			}
		}).start();
	}
	public static void VolatileExecutation_With_VolatileKeyword() {
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				int i = 0;
				//Infinite Loop
				while(true) {
					if(flag2 == 0) {
						System.out.println(i + " : Running...");
						i++;
					}
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				try {
					Thread.sleep(100);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				flag2 = 1;
				System.out.println("The value of the flag2 updated and thread 1 stopped");
			}
		}).start();
	}
}
