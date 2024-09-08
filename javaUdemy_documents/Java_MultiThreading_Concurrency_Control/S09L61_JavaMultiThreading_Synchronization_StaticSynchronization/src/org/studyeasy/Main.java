package org.studyeasy;

import java.util.Scanner;

import org.maincallsforclasses.SynchronizationBlockOnObject;
import org.maincallsforclasses.SynchronizationBlock_Intro;
import org.maincallsforclasses.SynchronizationMethod_Intro;
import org.maincallsforclasses.Synchronization_StaticSynchronization;

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
			case 8:
				//this means current object
				//Intrinsic lock or Monitor lock
				//These block should be private
				//In order to keep them private, Synchroniztion Block on object was introduced.
				//Recommended way
				SynchronizationBlockOnObject.Brackets_With_SynchronizedBlockOnObject();
				break;
			case 9:
				//When we are using synchronized, it is based on objcets. What if?
				//We make use of multiple objects and try to run the application.
				//It does not has consistency
				Synchronization_StaticSynchronization.StaticSynchronization();
				break;
			case 10:
				//Absolute Synchronization without any issues,then Static synchronization is solution
				//It does not has consistency
				Synchronization_StaticSynchronization.StaticSynchronization_AbsoluteSynchronization();
				break;
			case 11:
				//Making use of object
				//It has consistency
				Synchronization_StaticSynchronization.StaticSynchronization_AbsoluteSynchronization_UseOfObject();
				break;
			case 12:
				//Making property or field object as final. Cannot change value down the line.
				//It has consistency
				Synchronization_StaticSynchronization.StaticSynchronization_AbsoluteSynchronization_FinalKeyword();
			case 13:
				//When you don't want to your method to be accessed by multiple instances and you want to be absolute
				//synchronized throughout everywhere the application regardless of the object, Static is way to do this.
				//It is consistent.
				//Static synchronization
				Synchronization_StaticSynchronization.StaticSynchronization_StaticSynchronization();
				break;
			}
		sc.close();
	}
	//sync method - Thread 1 - 562  575
	//				Thread 2 - 1124 1144
	
	//sync block -  Thread 1 - 1136  1285
	//				Thread 2 - 1142 1293
}
