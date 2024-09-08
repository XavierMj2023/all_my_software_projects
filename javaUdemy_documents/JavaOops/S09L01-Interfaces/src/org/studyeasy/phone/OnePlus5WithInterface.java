package org.studyeasy.phone;

import org.studyeasy.phone_interface.Phone;

public class OnePlus5WithInterface implements Phone{

	@Override
	public String processor() {
		return "SD835";
	}

	@Override
	public String OS() {
		return "Android";
	}

	@Override
	public int spaceInGB() {
		return 64;
	}
	
}
