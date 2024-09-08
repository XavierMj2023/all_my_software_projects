package org.studyeasy;

import java.util.Scanner;

import org.javadirectory.FileHandlingCheckOS;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//File Handling Check OS Test
				FileHandlingCheckOS.FileHandlingDirectoryTest();
				break;
			case 2:
				//File Handling Check OS Demo
				FileHandlingCheckOS.FileHandlingCheckOSExe();
				break;
			case 3:
				//File Handling Check OS Demo 2
				FileHandlingCheckOS.FileHandlingCheckOS_Condition();
				break;
			}
		sc.close();
	}

}
