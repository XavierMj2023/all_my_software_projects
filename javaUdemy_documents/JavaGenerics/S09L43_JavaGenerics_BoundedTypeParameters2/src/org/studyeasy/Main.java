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

/*class Data<K extends Integer,V>{
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	public K getKey() {return key;}

	public V getValue() {return value;}
	
	@Override
	public String toString() {
		return "Data [key=" + key + ", value=" + value + "]";
	}
	
	
	 * You can bound - Bounded Type Parameter - Restricting the data  
	 * type of element like below
	 
	public <N extends Number,E> void display(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
	
}*/

class Data<K extends Integer,V extends Name>{
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	public K getKey() {return key;}

	public V getValue() {return value;}
	
	@Override
	public String toString() {
		return "Data [key=" + key + ", value=" + value + "]";
	}
	
	/*
	 * You can bound - Bounded Type Parameter - Restricting the data  
	 * type of element like below
	 */
	public <N extends Number,E> void display(N number, E element) {
		System.out.println("Number: "+number+ ",Element: "+element);
	}
	
}
class Name {
	private String name;

	public Name(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return "Name [name=" + name + "]";
	}

}

public class Main {

	public static void main(String[] args) {
		// Case 1
		//You get error
		/*
		 * Data<Integer, String> data = new Data<>(1, "Chaand");
		 * System.out.println(data); data.display(25.5254, '$');// Number: 25,Element: $
		 */
	
		// Case 2
		Data<Integer, Name> data = new Data<>(1, new Name("StudyEasy"));
		System.out.println(data);
		data.display(25.5254, '$');// Number: 25,Element: $
	}

}
