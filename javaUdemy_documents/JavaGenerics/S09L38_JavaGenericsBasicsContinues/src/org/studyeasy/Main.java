package org.studyeasy;

class Data{
	private Object object;

	public Data(Object object) {
		this.object = object;
	}
	 
	public Object getObject() {
		return object;
	}
}
//T means Type of Data

class GenericData<T>{
	private T data;

	public GenericData(T data) {
		this.data = data;
	}

	public T getData() {
		return data;
	}
	
}
public class Main {

	public static void main(String[] args) {
		Data data = new Data("Some Data");
		String x = (String)data.getObject();
		System.out.println("---This is a Standard Conversion from Object to String----");
		System.out.println("-----------------------------------------------------------");
		System.out.println(x);//Some Data
		System.out.println("-----------------------------------------------------------");
		
		System.out.println("---This is using Generics-----");
		System.out.println("-----------------------------------------------------------");
		GenericData genericdata = new GenericData("Some generic data");
		String y = (String)genericdata.getData();
		System.out.println(y);
		System.out.println("-----------------------------------------------------------");
		
		System.out.println("---This is using Generics using another solution-----");
		System.out.println("-----------------------------------------------------------");
		GenericData<String> genericdata2 = new GenericData("Some generic data");
		String y2 = genericdata2.getData();
		System.out.println(y2);
		System.out.println("-----------------------------------------------------------");
	
		//To Get rid of Warning 1
		System.out.println("---To get rid of Waring 1-----");
		System.out.println("GenericData<String> genericdata3 = new GenericData<String>(Some generic data);");
		System.out.println("-----------------------------------------------------------");
		GenericData<String> genericdata3 = new GenericData<String>("Some generic data");
		String y3 = genericdata3.getData();
		System.out.println(y3);
		System.out.println("-----------------------------------------------------------");
		
		//<> on the Right hand side is optional
		System.out.println("---<> on the Right hand side is optional-----");
		System.out.println("GenericData<String> genericdata3 = new GenericData<>(Some generic data);");
		System.out.println("-----------------------------------------------------------");
		GenericData<String> genericdata4 = new GenericData<>("Some generic data");
		String y4 = genericdata4.getData();
		System.out.println(y4);
		System.out.println("-----------------------------------------------------------");
		
	}
}
