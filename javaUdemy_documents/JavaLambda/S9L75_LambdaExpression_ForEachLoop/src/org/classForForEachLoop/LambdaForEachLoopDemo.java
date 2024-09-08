package org.classForForEachLoop;

import java.util.Arrays;
import java.util.List;

import org.interfaceforeachloop.Data;
import org.interfaceforeachloop.Data2;

public class LambdaForEachLoopDemo {

	public static void LambdaForEachLoopDemoExe() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		List<Integer> list = Arrays.asList(6,4,8,7,23,9,0);
		for (int x : list) {
			System.out.println(x);
		}
	}
	public static void LambdaForEachLoopDemoExe_EnhancedWayOfHandling() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		//Inside ForEachLoop we are using Lambda Expression
		List<Integer> list = Arrays.asList(6,4,8,7,23,9,0);
		list.forEach(i -> System.out.println(i));
	}
	public static void LambdaForEachLoopDemoExe_CustomObject() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		//Inside ForEachLoop we are using Lambda Expression
		List<Data> list = Arrays.asList(
				new Data("Chaand"),
				new Data("John"),
				new Data("Raj")
				);
		System.out.println(list);
	}
	public static void LambdaForEachLoopDemoExe_CustomObject_Getter() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		//Inside ForEachLoop we are using Lambda Expression
		//We are using Getter here also
		List<Data2> list = Arrays.asList(
				new Data2("Chaand"),
				new Data2("John"),
				new Data2("Raj")
				);
		list.forEach(temp -> System.out.println(temp.getName()));
	}
	public static void LambdaForEachLoopDemoExe_CustomObject_Getter_Braces() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		//Inside ForEachLoop we are using Lambda Expression
		//We are using Getter here also
		List<Data2> list = Arrays.asList(
				new Data2("Chaand"),
				new Data2("John"),
				new Data2("Raj")
				);
		list.forEach(temp -> {
			System.out.println(temp.getName());
		});
	}
	public static void LambdaForEachLoopDemoExe_CustomObject_Getter_Braces_Condition() {
		//Takes all parameters and returns arraylist (list) and saves
		//multiple statements
		//Inside ForEachLoop we are using Lambda Expression
		//We are using Getter here also
		List<Data2> list = Arrays.asList(
				new Data2("Chaand"),
				new Data2("John"),
				new Data2("Raj")
				);
		list.forEach(temp -> {
			 if(temp.getName().equals("Chaand")) {
				 System.out.print("Founder StudyEasy: ");
			 }
			 System.out.println(temp.getName());
		});
	}
}
