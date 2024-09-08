package org.studyeasy.cars;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.studyeasy.interfaces.Car;
import org.studyeasy.interfaces.Engine;

public class Corolla implements Car {


// 	Case 4
	
	@Autowired
	@Qualifier("V6Engine")
	Engine engine;

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " + engine.specs());
	}

}
