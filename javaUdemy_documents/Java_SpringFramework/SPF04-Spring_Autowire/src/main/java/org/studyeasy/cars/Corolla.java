package org.studyeasy.cars;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car;

@Component("corolla")
public class Corolla implements Car {
	
	Engine engine = new Engine();

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " +engine.type);
	}

}
