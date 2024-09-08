package org.studyeasy;

import java.util.Stack;

public class Main {

	public static void main(String[] args) {
		Stack<Integer> numbers = new Stack<>();
		numbers.push(25);
		numbers.push(35);
		int x = numbers.search(35);
		System.out.println("---This is the Stack First Trial----");
		System.out.println(x);//1 First Element
		
		Stack<Integer> numbers2 = new Stack<>();
		numbers2.push(25);
		numbers2.push(35);
		numbers2.push(45);
		int x2 = numbers2.search(45);
		System.out.println("---This is the Stack Second Trial----");
		System.out.println(x2);//1 First Element
		//Getting the value
		System.out.println(numbers.get(1));//35
		
		//Instead of Search, using indexOf()
		Stack<Integer> numbers3 = new Stack<>();
		numbers3.push(25);
		numbers3.push(35);
		numbers3.push(45);
		int x3 = numbers3.indexOf(45);
		System.out.println("---indexOf()----");
		System.out.println(x3);//2
		System.out.println(numbers3.get(2));//45
		
		//Index - It will start from top.
		//Search - It will start from bottom.
	}
}
