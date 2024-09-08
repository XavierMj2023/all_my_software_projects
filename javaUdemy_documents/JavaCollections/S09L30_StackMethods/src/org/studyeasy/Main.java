package org.studyeasy;

import java.util.Stack;

public class Main {

	public static void main(String[] args) {
		Stack<Integer> numbers = new Stack<>();
		numbers.push(25);
		numbers.push(5);
		numbers.push(2);
		numbers.push(225);
		numbers.push(251);
		System.out.println(numbers);//[25, 5, 2, 25, 225, 251]
		//System.out.println(numbers[0]);//Error
		
		System.out.println(numbers.isEmpty());//false
		
		//The count will start from the last element
		System.out.println(numbers.search(2));//3 It is third element
		System.out.println(numbers.search(5));//4 It is fourth element
		
		//Pop The Element
		System.out.println(numbers.pop());//251
		System.out.println(numbers);//[25, 5, 2, 225]
		
	}

}
