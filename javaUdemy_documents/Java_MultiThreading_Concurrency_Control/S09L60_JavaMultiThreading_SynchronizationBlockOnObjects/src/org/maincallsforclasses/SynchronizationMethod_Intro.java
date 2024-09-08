package org.maincallsforclasses;

import org.usemclasses.Brackets;
import org.usemclasses.Brackets_With_SynchronizedKeyword;

public class SynchronizationMethod_Intro {
	
	public static void SynchronizationMethod_Intro_pa() {
		
		Brackets brackets = new Brackets();
		brackets.generate();
	}
	public static void SynchronizationMethod_Intro_CreatingThread() {
		
		Brackets brackets = new Brackets();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets.generate();
				}
			}
		}).start();
	}
	public static void SynchronizationMethod_Intro_CreatingThread_With_SynchronizedKeyword() {
		
		Brackets_With_SynchronizedKeyword brackets = new Brackets_With_SynchronizedKeyword();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets.generate();
				}
			}
		}).start();
	}
}
