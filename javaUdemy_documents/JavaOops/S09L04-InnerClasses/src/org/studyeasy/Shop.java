package org.studyeasy;

import org.studyeasy.shop.Door;

public class Shop {

	public static void main(String[] args) {
		Door door = new Door();
		door.shopStatus();	//Shop is Closed ,Please Visit Later
		
		door.getLock().setLock(false);
		door.shopStatus();  //Welcome we are open.
	}

}
