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
		
		//Main.display(list);
		
		//Main.display2(list);
		
		 Main.display4(list);
	}
	//Accepting raw list is not good because it affects performance 
	//There were be a lot of casting
	public static void display(List list) {
		for (Object data : list) {
			System.out.println(data);
		}
	}
	
	//Making use of WildCards
	//? - We do not know what type of data we may be receiving - Valid Type
	//We will be receiving data and based on that optimize
	public static void display2(List<?> list) {
		for (Object data : list) {
			System.out.println(data);
		}
	}
	
	//Upper Bound And Lower Bound
	//Upper Bound
	public static void display3(List<? extends Vehicle> list) {
		for (Vehicle data : list) {
			System.out.println(data);
		}
	}
	
	//Inner Bound like 'super'
	public static void display4(List<? super Vehicle> list) {
		for (Object data : list) {
			System.out.println(data);
		}
	}
}
