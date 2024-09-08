package org.studyeasy;

//You can add much as types as possible in Java Generics
/*class Data<K,V>{
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	public K getKey() {
		return key;
	}

	public V getValue() {
		return value;
	}
	
	//Generic Method
	public <N,E> void display(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
	
	 * You can bound - Bounded Type Parameter - Restricting the data  
	 * type of element like below
	 
	public <N extends Number,E> void display2(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
}*/

class Data<K extends Integer,V>{
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	public K getKey() {
		return key;
	}

	public V getValue() {
		return value;
	}
	
	//Generic Method
	public <N,E> void display(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
	/*
	 * You can bound - Bounded Type Parameter - Restricting the data  
	 * type of element like below
	 */
	public <N extends Number,E> void display2(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
}

public class Main {

	public static void main(String[] args) {
		//Case 1
		Data<Integer, String> data = new Data<>(1, "Chaand");
		data.display(25, '$');// Number: 25,Element: $

		// data.display("*",'$');//Number: *,Element: $

		// After Bounding you get error, because there is datatype restriction
		// data.display2("*",'$');
		// data.display2('x','$');
		data.display2(25, '$');
		data.display2(25.5254f, '$');
		
		System.out.println("--*****------Class - Data<K extends Integer,V>---------******");
		
		//Case 2
		Data<Integer, String> data2 = new Data<>(1, "Chaand");
		//Data<String, String> data2 = new Data<>("Test", "Chaand");
		//You get error stating that it is out of bounds
		
		data2.display(25, '$');// Number: 25,Element: $

		// data.display("*",'$');//Number: *,Element: $

		// After Bounding you get error, because there is datatype restriction
		// data2.display2("*",'$');
		// data2.display2('x','$');
		data2.display2(25, '$');
		data2.display2(25.5254f, '$');
	}

}
