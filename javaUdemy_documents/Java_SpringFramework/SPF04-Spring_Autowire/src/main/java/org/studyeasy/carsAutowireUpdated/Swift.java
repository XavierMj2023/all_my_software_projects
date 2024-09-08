package org.studyeasy.carsAutowireUpdated;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car_Autowire_Updated;

@Component("swiftU")
public class Swift implements Car_Autowire_Updated{

	@Override
	public void specs() {
		System.out.println("Hatchback from Suzuki");
	}
	
}
