package org.maincallsforclasses;

import org.usemclasses.Brackets_With_StaticSynchronization;
import org.usemclasses.Brackets_With_StaticSynchronization_StaticSynchnorization;
import org.usemclasses.Brackets_With_StaticSynchronization_UseOfFinalKeyword_;
import org.usemclasses.Brackets_With_StaticSynchronization_UseOfObject;
import org.usemclasses.Brackets_With_SynchronizedKeyword;

public class Synchronization_StaticSynchronization {
	
	public static void StaticSynchronization() {
		
		Brackets_With_SynchronizedKeyword brackets1 = new Brackets_With_SynchronizedKeyword();
		Brackets_With_SynchronizedKeyword brackets2 = new Brackets_With_SynchronizedKeyword();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets1.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets2.generate();
				}
			}
		}).start();
	}
	public static void StaticSynchronization_AbsoluteSynchronization() {
		
		Brackets_With_StaticSynchronization brackets1 = new Brackets_With_StaticSynchronization();
		Brackets_With_StaticSynchronization brackets2 = new Brackets_With_StaticSynchronization();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets1.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets2.generate();
				}
			}
		}).start();
	}
	public static void StaticSynchronization_AbsoluteSynchronization_UseOfObject() {
		
		Brackets_With_StaticSynchronization_UseOfObject brackets1 = new Brackets_With_StaticSynchronization_UseOfObject();
		Brackets_With_StaticSynchronization_UseOfObject brackets2 = new Brackets_With_StaticSynchronization_UseOfObject();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets1.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets2.generate();
				}
			}
		}).start();
	}
	public static void StaticSynchronization_AbsoluteSynchronization_FinalKeyword() {
		
		Brackets_With_StaticSynchronization_UseOfFinalKeyword_ brackets1 = new Brackets_With_StaticSynchronization_UseOfFinalKeyword_();
		Brackets_With_StaticSynchronization_UseOfFinalKeyword_ brackets2 = new Brackets_With_StaticSynchronization_UseOfFinalKeyword_();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets1.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
				   brackets2.generate();
				}
			}
		}).start();
	}
	public static void StaticSynchronization_StaticSynchronization() {
		
		/*
		 * Brackets_With_StaticSynchronization_StaticSynchnorization brackets1 = new
		 * Brackets_With_StaticSynchronization_StaticSynchnorization();
		 * Brackets_With_StaticSynchronization_StaticSynchnorization brackets2 = new
		 * Brackets_With_StaticSynchronization_StaticSynchnorization();
		 */
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
					Brackets_With_StaticSynchronization_StaticSynchnorization.generate();
				}
			}
		}).start();
		new Thread(new Runnable() {
			
			@Override
			public void run() {
				for(int i = 0; i < 5; i++) {
					Brackets_With_StaticSynchronization_StaticSynchnorization.generate();
				}
			}
		}).start();
	}
}
