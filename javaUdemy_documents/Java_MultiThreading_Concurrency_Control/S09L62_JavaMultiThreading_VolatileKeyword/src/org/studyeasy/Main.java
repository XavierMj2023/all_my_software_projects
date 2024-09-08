package org.studyeasy;

import java.util.Scanner;

import org.classesForUse.VolatileIntro;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				VolatileIntro.VolatileExecutation();
				break;
			case 2:
				//Use of Volatile keyword - Caching by thread not happen and application will run as expected
				VolatileIntro.VolatileExecutation_With_VolatileKeyword();
				break;
			}
		sc.close();
	}

}
