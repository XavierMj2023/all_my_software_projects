package org.studyeasy.cars;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car;

@Component("co")
public class Corolla implements Car {

	Engine engine;

//  Scenario 1

//	@Autowired
//	public Corolla(Engine engine) {
//		engine.type = "V6";
//		//this.engine = engine;
//	}

//  Scenario 2

//	public void setEngine(Engine engine) {
//		engine.type = "V10";
//		this.engine = engine;
//	}

//	Scenario 2 - Add Autowire to the setter to make setter execute or else it gives a 
//				 default value.

//	@Autowired
//	public void setEngine(Engine engine) {
//		engine.type = "V10";
//		this.engine = engine;
//	}

//	Scenario 2 - Comment out the (this.engine = engine;)

	@Autowired
	public void setEngine(Engine engine) {
		engine.type = "V10";
		this.engine = engine;
	}

	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " + engine.type);
	}

}
