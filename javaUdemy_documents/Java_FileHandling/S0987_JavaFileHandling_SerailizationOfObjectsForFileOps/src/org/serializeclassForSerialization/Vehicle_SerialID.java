package org.serializeclassForSerialization;

import java.io.Serializable;

public class Vehicle_SerialID implements Serializable {

	/**
	 * 
	 */
	/* private static final long serialVersionUID = -2287110992435913468L; */
	
	private static final long serialVersionUID = -2287110992435913469L;
	private final String type;
	private final int number;
	
	public Vehicle_SerialID(String type, int number) {
		this.type = type;
		this.number = number;
	}

	@Override
	public String toString() {
		return "Vehicle [Type=" + type + ", number=" + number + "]";
	}
}
