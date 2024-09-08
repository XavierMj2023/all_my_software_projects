package org.serializeclassForSerialization;

import java.io.Serializable;

public class VehicleAdvanced2 implements Serializable {

	private final String type; 
	private final int number;


	//You are getting the error because modifications were made like below code; Try using this or make any
	//minor modifications in class to see the error or change. Can use below commented code(Uncomment it).
	//And also comment the original code which is modified to see the change.

	//private String type;
	//private int number;


	public VehicleAdvanced2(String type, int number) {
		this.type = type;
		this.number = number;
	}

	@Override
	public String toString() {
		return "Vehicle [Type=" + type + ", number=" + number + "]";
	}
}
