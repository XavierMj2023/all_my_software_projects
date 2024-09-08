package org.studyeasy.cars;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car;
import org.studyeasy.interfaces.Engine;

@Component("co")
public class Corolla implements Car {

// 	Case 1
	
//	@Autowired
//	Engine engine;
	
//	Case 2
	
//	@Autowired
//	Engine v6;
	
//	Case 3
	
//	@Autowired
//	Engine V6Engine;
	
// 	Case 4
	@Autowired
	@Qualifier("V6Engine")
	Engine engine;

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " + engine.specs());
	}

}
