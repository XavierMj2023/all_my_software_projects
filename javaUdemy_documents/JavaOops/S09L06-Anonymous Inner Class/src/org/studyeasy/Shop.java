package org.studyeasy;

import org.studyeasy.shop.Door;

public class Shop {

	public static void main(String[] args) {
		/*
		Door door = new Door();
		door.getLock().test();
		*/
		
		/*
		Door door = new Door();
		System.out.println(door.getLock().isUnlocked("test")); //false
		
		System.out.println(door.getLock().isUnlocked("qwerty")); //true
		*/
		
		Door door = new Door();
		if(door.getLock().isUnlocked(args[0])) {
			System.out.println("Welcome ,we are open");
		}else {
			System.out.println("We are closed ,visit later");
		}
		
	}

}
