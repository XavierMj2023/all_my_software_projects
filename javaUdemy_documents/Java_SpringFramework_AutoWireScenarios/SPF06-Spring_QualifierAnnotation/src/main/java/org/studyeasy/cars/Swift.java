package org.studyeasy.cars;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car;

@Component("sw")
public class Swift implements Car{

	@Override
	public void specs() {
		System.out.println("Hatchback from Suzuki");
	}
	
}