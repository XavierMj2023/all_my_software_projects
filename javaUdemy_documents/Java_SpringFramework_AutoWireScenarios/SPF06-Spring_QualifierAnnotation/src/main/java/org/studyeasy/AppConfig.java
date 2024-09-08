package org.studyeasy;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

// Telling Spring that it is configuration class and which particular package to scan for 
// components

@Configuration
@ComponentScan("org.studyeasy")
public class AppConfig {
	
}
