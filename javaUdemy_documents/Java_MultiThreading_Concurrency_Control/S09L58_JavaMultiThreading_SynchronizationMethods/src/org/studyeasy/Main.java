package org.studyeasy;

import java.util.Scanner;

import org.maincallsforclasses.SynchronizationMethod_Intro;

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
				//SynchronizationMethod_Intro_With Bracket Class Generate a pattern
				SynchronizationMethod_Intro.SynchronizationMethod_Intro_pa();
				break;
			case 2:
				//There are scenarios, where we don't want a method to be paused in between the executation
				//In those kind of scenarios, we can make use of Synchronized methods
				//There is a consistency in pattern; means it varies
				SynchronizationMethod_Intro.SynchronizationMethod_Intro_CreatingThread();
				break;
			case 3:
				//Synchronized Keyword
				//It comes before the access specifior 
				//Pattern does not varies no matter what it is.
				SynchronizationMethod_Intro.SynchronizationMethod_Intro_CreatingThread_With_SynchronizedKeyword();
				break;
			}
		sc.close();
	}

}
