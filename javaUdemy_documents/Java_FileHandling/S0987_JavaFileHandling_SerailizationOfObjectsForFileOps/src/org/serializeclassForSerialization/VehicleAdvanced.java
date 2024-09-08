package org.serializeclassForSerialization;

import java.io.Serializable;

public class VehicleAdvanced implements Serializable {

	private String type;
	private int number;
	
	public VehicleAdvanced(String type, int number) {
		this.type = type;
		this.number = number;
	}

	@Override
	public String toString() {
		return "Vehicle [Type=" + type + ", number=" + number + "]";
	}
}
