package org.usemclasses;

public class Brackets_With_StaticSynchronization_UseOfFinalKeyword_ {

	final private Object lock = "lock";
	public void generate(){

		//This is locked and cannot be paused when it comes out to executing part.
		//of the method.
		//Synchronized Block
		synchronized(lock) {
			for(int i = 1; i <= 20; i++) {
				if(i <= 10) {
					System.out.print('[');
				}else {
					System.out.print(']');
				}
			}
			System.out.println();
		}
	}
}
