package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

class Data{
	private Object object;

	public Data(Object object) {
		this.object = object;
	}

	@Override
	public String toString() { 
		//return (String) object;
		  return object.toString(); 
	  }
	 
	
	public Object getObject() {
		return object;
	}
}
class Name{
	private String name;

	public Name(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return name;
	}
}
public class Main {

	public static void main(String[] args) {
		List<Data> elements = new LinkedList<>();
		elements.add(new Data("Chaand"));
		elements.add(new Data('$'));
		elements.add(new Data(25));
		elements.add(new Data(52.65));
		elements.add(new Data("Chaand"));
		
		//So you get error stating that cannot be casted to cast.Use tostring()
		//Of object directly. Java will directly accordingly convert to string.
		//System.out.println(elements);
		
		System.out.println(elements);//[Chaand, $, 25, 52.65, Chaand]
		
		List<Data> element = new LinkedList<>();
		element.add(new Data("Chaand"));
		element.add(new Data('$'));
		element.add(new Data(25));
		element.add(new Data(52.65));
		element.add(new Data(new Name("Studyeasy")));
		
		System.out.println(element);//[Chaand, $, 25, 52.65, Studyeasy]
		
		//cannot convert from Data to String
		/*
		 * String x = new Data("Hello World"); System.out.println(x);
		 */
		
		//solution 1
		/*
		 * String x = (String)new Data("Hello World"); System.out.println(x);
		 */
		 
		 //solution 2
			/*
			 * Data x = new Data("Hello World"); System.out.println(x.getObject());//Hello
			 * World
			 * }
			 */	
		
		//solution 3
		//Because The Object has also ToString()
		/*
		 * Data x = new Data(new Name("Chaand")); System.out.println(x.getObject());
		 */
		
		//solution 4
		//Try Passing 25 instead of 'Chaand', you get error. 
		//The constructor Name(int) is undefined
		/*
		 * Data x = new Data(new Name(25)); System.out.println(x.getObject());
		 */
		
		//solution 5
		//Converting object to string using tostring()
		//You get error like  - Type mismatch: cannot convert from Data to String
		
		/*
		 * String x = new Data("Hello World"); System.out.println(x);
		 */
		
		//Now Solution use ToString()
		String x = new Data("Hello World").toString();
		System.out.println(x);
	}
}
