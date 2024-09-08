package org.studyeasy.carsAutowire;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car_Autowire;

@Component("swift2")
public class Swift implements Car_Autowire{

	@Override
	public void specs() {
		System.out.println("Hatchback from Suzuki");
	}
	
}
