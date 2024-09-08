package org.studyeasy.carsAutowire;

import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car_Autowire;

@Component("corollaAutowire")
public class Corolla implements Car_Autowire {
	
	Engine engine = new Engine();

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " +engine.type);
	}

}
