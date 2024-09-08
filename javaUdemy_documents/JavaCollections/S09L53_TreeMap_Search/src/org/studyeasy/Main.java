package org.studyeasy;

import java.util.Scanner;

import org.classesusage.MapSearchDemo;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Map Search Demo - One way to get a value
				MapSearchDemo.MapSearch();
			case 2:
				//We know the value, but want to understand the key
				MapSearchDemo.MapSearch_Using_KnownValue_But_UnderstandKey();
			}
		sc.close();
	}

}
