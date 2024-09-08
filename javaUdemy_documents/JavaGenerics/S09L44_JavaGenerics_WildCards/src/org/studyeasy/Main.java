package org.studyeasy;

import java.util.ArrayList;
import java.util.List;

class Vehicle {
	private int id;

	public Vehicle(int id) {
		this.id = id;
	}

	@Override
	public String toString() {
		return "Vehicle [id=" + id + "]";
	}
}
class Car extends Vehicle{
	
	private String model;

	public Car(int id, String model) {
		super(id);
		this.model = model;
	}

	@Override
	public String toString() {
		return "Car [model=" + model + ", toString()=" + super.toString() + "]";
	}
	
}
public class Main {

	public static void main(String[] args) {
		List<Vehicle> list = new ArrayList<>();
		list.add(new Vehicle(1));
		list.add(new Vehicle(2));
		list.add(new Vehicle(3));
		list.add(new Vehicle(4));
		list.add(new Car(5, "S40"));
		//System.out.println(list);
		
		Main.display(list);
	}
	//Accepting raw list is not good because it affects performance 
	//There were be a lot of casting
	public static void display(List list) {
		for (Object data : list) {
			System.out.println(data);
		}
	}
}
