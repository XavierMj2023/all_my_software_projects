package org.studyeasy;

import java.util.ArrayList;
import java.util.List;

class Data{
	public <E> void printListData(List<E> list) {
		for (E element : list) {
			System.out.println(element);
		}
	}
	public <E> void printArrayData(E[] arrayData) {
		for (E element : arrayData ) {
			System.out.println(element);
		}
	}
}
public class Main {

	public static void main(String[] args) {
		List<Integer> list1 = new ArrayList<>();
		list1.add(12);
		list1.add(13);
		list1.add(14);
		list1.add(15);
		list1.add(16);
		System.out.println("Printing Elements Integer from Generic Method");
		new Data().printListData(list1);
		
		List<String> list2 = new ArrayList<>();
		list2.add("One");
		list2.add("Two");
		list2.add("Three");
		System.out.println("Printing Elements String from Generic Method");
		new Data().printListData(list2);
		
		//Create Array Of String
		System.out.println("----Creating Array Of String----");
		String[] stringArray = {"One","Two","Three","four"};
		new Data().printArrayData(stringArray);
		
		//Create Array Of Integer
		System.out.println("----Creating Array Of Integer----");
		int[] intArray = {1,2,3,4};
		
		//Error we getting because it only works on objects
		//new Data().printArrayData(intArray);
		
		Integer[] intArray2 = {1,2,3,4};
		new Data().printArrayData(intArray2);
	}

}
