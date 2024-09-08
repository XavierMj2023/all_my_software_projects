package org.studyeasy.SpringStarter;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class SpringStarterApplication {

	public static void main(String[] args) {
		SpringApplication.run(SpringStarterApplication.class, args);
	}
	// @Bean
    // public CommandLineRunner createDbDirectory() {
    //     return args -> {
    //         File dbDir = new File("C:/Users/dinit/db/");
    //         if (!dbDir.exists()) {
    //             if (dbDir.mkdirs()) {
    //                 System.out.println("Directory created: " + dbDir.getAbsolutePath());
    //             } else {
    //                 System.err.println("Failed to create directory: " + dbDir.getAbsolutePath());
    //             }
    //         }
    //     };
    // }
}
