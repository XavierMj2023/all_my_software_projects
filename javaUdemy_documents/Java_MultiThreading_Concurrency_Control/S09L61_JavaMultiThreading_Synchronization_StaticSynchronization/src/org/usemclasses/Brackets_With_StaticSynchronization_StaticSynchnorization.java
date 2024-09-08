package org.usemclasses;

public class Brackets_With_StaticSynchronization_StaticSynchnorization {

	//Static method
	synchronized public static void generate(){
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
