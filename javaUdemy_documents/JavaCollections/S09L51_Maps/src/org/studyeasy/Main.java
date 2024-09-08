package org.studyeasy;

import java.util.Scanner;

import org.classesdemo.MapIterateElements;
import org.classesdemo.MapWorking;
import org.classesdemo.Map_With_DuplicateKeyAndValues;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Working Of Map
			MapWorking.Map_Working();
		case 2:
			//Working of Map with duplicate key and values
			Map_With_DuplicateKeyAndValues.MapWith_DuplicateKeyAndValues();
		case 3:
			//Working of Map with duplicate key and values and adding a value
			Map_With_DuplicateKeyAndValues.MapAdd();
		case 4:
			//Iterate over Map
			MapIterateElements.MapIterateTheElements();
		}
		sc.close();
	}

}
