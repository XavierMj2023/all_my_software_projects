package org.studyeasy.cars;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car;

@Component
public class Corolla implements Car {

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota");
	}

}
