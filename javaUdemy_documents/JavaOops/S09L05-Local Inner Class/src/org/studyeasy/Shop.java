package org.studyeasy;

import org.studyeasy.shop.Door;

public class Shop {

	public static void main(String[] args) {
		/*
		//Object of Door Type
		Door door = new Door();
		
		/*
		System.out.println(door.isLocked("test")); //true
		
		System.out.println(door.isLocked("qwerty")); //false
		*/
		
		/*
		if(door.isLocked(args[0])) {
			System.out.println("Shop is closed,Visit Later");
		}else {
			System.out.println("Welcome,we are open :");
		}
		
		System.out.println(args[1]);
		System.out.println(args[2]);
		*/
		//----------------------------------------------------------------------
		
		//Demonstration of Anonymous Object
		//Creating a Nameless object ,then directly accessing the method
		//new Door() ;Line 32
		
		if(new Door().isLocked(args[0])) {
			System.out.println("Shop is closed,Visit Later");
		}else {
			System.out.println("Welcome,we are open :");
		}
		System.out.println(args[1]);
		System.out.println(args[2]);
	}

}
