package org.studyeasy.phone;

import org.studyeasy.phone_interface.Phone;

public class Iphone8 implements Phone{

	@Override
	public String processor() {
		return "All";
	}

	@Override
	public String OS() {
		return "IOS";
	}

	@Override
	public int spaceInGB() {
		return 64;
	}
	/*
	 * Here when you try to change to spaceInGB to spaceInGBs ,you get error.
	 * Implement exact methods in these classes.
	 * Restriction is there'
	 * 
		@Override
		public int spaceInGBs() {
			return 64;
		}
		
	*/
}
