package org.studyeasy;

import java.util.Scanner;

import org.classes.synchronization.Synchronization_Intro;

public class Main {

	//Common Resource - A Resource which will be sharing among multiple threads
	//Issue can be fixed by Synchronization
	public static void main(String[] args) throws InterruptedException{
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Synchronization Intro
				Synchronization_Intro.Synchronization_Exe();
				break;
			case 2:
				//Synchronization Intro_Part 2
				Synchronization_Intro.Synchronization_Exe_Part2();
				break;
			case 3:
				//Synchronization Intro_Sleep()
				Synchronization_Intro.Synchronization_Exe_With_SleepMethod();
				break;
			}
		sc.close();
	}

}
