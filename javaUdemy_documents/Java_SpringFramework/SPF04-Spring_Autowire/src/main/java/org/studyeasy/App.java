package org.studyeasy;

import org.studyeasy.cars.Corolla;
import org.studyeasy.cars.Swift;
import org.studyeasy.interfaces.Car;

public class App {

	public static void main(String[] args) {
		Car swift = new Swift();
		swift.specs();
		
		Car corolla = new Corolla();
		corolla.specs();
	}

}
