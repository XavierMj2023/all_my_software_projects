package org.studyeasy;

import org.springframework.context.annotation.Bean;
import org.studyeasy.cars.Corolla;
import org.studyeasy.cars.Swift;
import org.studyeasy.specs.EngineType;

public class AppConfig {
	
	@Bean("co")
	public Corolla corolla(){
		return new Corolla();
	}
	
	@Bean("swift")
	public Swift swift(){
		return new Swift();
	}
	
	@Bean("UnknownEngine")
	public EngineType type(){
		return new EngineType();
	}
	
	@Bean("V6Engine")
	public EngineType v6type(){
		return new EngineType("V6 Engine");
	}
	
}
