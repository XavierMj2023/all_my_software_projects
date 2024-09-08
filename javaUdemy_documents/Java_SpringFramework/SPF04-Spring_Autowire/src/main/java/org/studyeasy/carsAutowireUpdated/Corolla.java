package org.studyeasy.carsAutowireUpdated;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.studyeasy.interfaces.Car_Autowire_Updated;

@Component("corollaU")
public class Corolla implements Car_Autowire_Updated {
	
	@Autowired
	Engine engine;
	
	/*
	 * This required parameter points that Spring should autowire or not 
	 * 
	 * @Autowired(required = true) 
	 * Engine engine;
	 */
	
	
	@Override
	public void specs() {
		System.out.println("Sedan from Toyota wit engine as : " +engine.type);
	}

}
