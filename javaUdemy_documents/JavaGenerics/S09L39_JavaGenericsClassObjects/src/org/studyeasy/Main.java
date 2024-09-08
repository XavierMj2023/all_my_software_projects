package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

/*
 * class Data{
	private Object object;

	public Data(Object object) {
		this.object = object;
	}

	@Override
	public String toString() {
		return object.toString();
	}
	
}*/

class Data<T>{
	private T object;

	public Data(T object) {
		this.object = object;
	}

	@Override
	public String toString() {
		return object.toString();
	}
}
public class Main {

	public static void main(String[] args) {
		List<Data> elements = new LinkedList<>();
		elements.add(new Data("Chaand"));
		elements.add(new Data('$'));
		elements.add(new Data(25));
		elements.add(new Data(52.65));

		//Case 1
		System.out.println("Printing the elements");
		System.out.println("----------------------");
		for (Object data : elements) {
			System.out.println(data);
		}
		System.out.println("----------------------");
		
		//Case 2
		//But no need to use this
		/*
		 * List<Data<java.io.Serializable>> elements2 = new
		 * LinkedList<Data<java.io.Serializable>>(); elements2.add(new
		 * Data<>("Chaand")); elements2.add(new Data<>('$')); elements2.add(new
		 * Data<>(25)); elements2.add(new Data<>(52.65));
		 * 
		 * System.out.println("Printing the elements using Serlizable");
		 * System.out.println("----------------------"); for (Object data : elements2) {
		 * System.out.println(data); } System.out.println("----------------------");
		 */
		
		//Case 3
		List<Data<Object>> elements3 = new LinkedList<>();
		elements3.add(new Data<Object>("Chaand"));
		elements3.add(new Data<Object>('$'));
		elements3.add(new Data<Object>(25));
		elements3.add(new Data<Object>(52.65));

		System.out.println("Printing the elements List<Data<Object>>");
		System.out.println("----------------------");
		for (Object data : elements3) {
			System.out.println(data);
		}
		System.out.println("----------------------");
		
		//Case 4
		//<Object> You can remove Object inside <> and keep like this.
		List<Data<Object>> elements4 = new LinkedList<>();
		elements4.add(new Data<>("Chaand"));
		elements4.add(new Data<>('$'));
		elements4.add(new Data<>(25));
		elements4.add(new Data<>(52.65));

		System.out.println("Printing the elements List<Data<Object>> and elements4.add(new Data<>(Chaand));");
		System.out.println("----------------------");
		for (Object data : elements4) {
			System.out.println(data);
		}
		System.out.println("----------------------");
		
		//Case 5
		/*
		 * List<Data<String>> elements5 = new LinkedList<>(); elements5.add(new
		 * Data<>("Chaand")); elements5.add(new Data<>('$')); elements5.add(new
		 * Data<>(25)); elements5.add(new Data<>(52.65));
		 * 
		 * System.out.
		 * println("Printing the elements List<Data<String>>  and elements4.add(new Data<>(Chaand));"
		 * ); System.out.println("----------------------"); for (Object data :
		 * elements5) { System.out.println(data); }
		 * System.out.println("----------------------");
		 */
		
		//Case 6
		List<Data<String>> elements6 = new LinkedList<>();
		elements6.add(new Data<>("Chaand"));
		elements6.add(new Data<>("StudyEasy"));

		System.out.println("Printing the elements (String)");
		System.out.println("----------------------");
		
		
		/* Case 101
		 * 
		 * for (Object data : elements6) { System.out.println(data); }
		 * 
		 */
		
		
		/* Case 102 - You get error stating that incomapatible data type
		 * 
		 * for (String data : elements6) { System.out.println(data); }
		 * 
		 */
		
		// Case 103
		for (Data<String> data : elements6) {
			System.out.println(data);
		}
		System.out.println("----------------------");
	}
}
