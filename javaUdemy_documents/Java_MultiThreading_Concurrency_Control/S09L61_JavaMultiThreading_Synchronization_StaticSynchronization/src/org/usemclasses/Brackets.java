package org.usemclasses;

public class Brackets {
	
	public void generate() {
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
