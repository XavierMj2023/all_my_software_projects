package org.studyeasy;

import java.util.Scanner;

import org.filedeldemo.FileDeletion;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//File Deletion Test
				FileDeletion.FileDeletionTest();
				break;
			case 2:
				//File Deletion Demo
				FileDeletion.FileDeletionDemo();
				break;
			}
		sc.close();
	}

}
