package org.studyeasy;

import java.util.Scanner;

import org.methodsOfScannerClass.ScannerAndBuffered;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Scanner Class
				ScannerAndBuffered.ScannerDemo();
				break;
			}
		sc.close();
	}

}
