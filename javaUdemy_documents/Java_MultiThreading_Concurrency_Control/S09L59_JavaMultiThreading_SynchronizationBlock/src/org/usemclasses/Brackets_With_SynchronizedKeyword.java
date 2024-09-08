package org.usemclasses;

public class Brackets_With_SynchronizedKeyword {
	
	synchronized public void generate() {
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
