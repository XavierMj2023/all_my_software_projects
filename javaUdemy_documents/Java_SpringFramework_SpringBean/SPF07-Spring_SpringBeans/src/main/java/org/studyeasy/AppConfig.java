package org.studyeasy;

import org.springframework.context.annotation.Bean;
import org.studyeasy.cars.Corolla;
import org.studyeasy.cars.Swift;
import org.studyeasy.specs.V6;
import org.studyeasy.specs.V8;

public class AppConfig {
	
	@Bean("co")
	public Corolla corolla(){
		return new Corolla();
	}
	
	@Bean("swift")
	public Swift swift(){
		return new Swift();
	}
	
	@Bean("V6Engine")
	public V6 v6(){
		return new V6();
	}
	
	@Bean("V8Engine")
	public V8 v8(){
		return new V8();
	}
}
