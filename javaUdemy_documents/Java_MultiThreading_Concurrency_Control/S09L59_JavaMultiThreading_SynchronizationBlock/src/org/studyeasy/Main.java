package org.studyeasy;

import java.util.Scanner;

import org.maincallsforclasses.SynchronizationBlock_Intro;
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
			case 4:
				//Synchronized Block
				//We do not want to use synchronized for entire method, but only for some parts.
				SynchronizationBlock_Intro.SynchronizationBlock();
				break;
			case 5:
				//Mimic some processing
				SynchronizationBlock_Intro.SynchronizationBlock_Mimic();
				break;
			case 6:
				//SynchronizationBlock_Mimic_With_AnotherForLoop
				SynchronizationBlock_Intro.SynchronizationBlock_Mimic_With_AnotherForLoop();
				break;
			case 7:
				//SynchronizationBlock_Mimic_With_Object(this keyword) 
				//There is a monitor lock by the JVM and it will take care of Locking mechanism
				//This is the advantage of Synchronized Block where it gives us additional power/control on 
				//how much portion of code/method we need to keep in sync.
				SynchronizationBlock_Intro.Brackets_With_SynchronizedBlock_Mimic_Another_SynchronizedWith_object_this();
				break;
			}
		sc.close();
	}
	//sync method - Thread 1 - 562  575
	//				Thread 2 - 1124 1144
	
	//sync block -  Thread 1 - 1136  1285
	//				Thread 2 - 1142 1293
}
