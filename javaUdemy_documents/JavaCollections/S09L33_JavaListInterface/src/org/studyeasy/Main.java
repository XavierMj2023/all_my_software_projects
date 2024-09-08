package org.studyeasy;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		LinkedList<String> list1 = new LinkedList<>();
		list1.add("Chaand");
		list1.add("Jai");
		list1.add("Veeru");
		
		ArrayList<String> list2 = new ArrayList<>();
		list2.add("StudyEasy");
		list2.add("organization");
		list2.add("team");
		
		System.out.println(list1);//[Chaand, Jai, Veeru]
		System.out.println(list2);//[StudyEasy, organization, team]
		System.out.println("--------------------------------------------------");
		//forEach Loop
		System.out.println("---List 1 Elements");
		for (String name : list1) {
			System.out.println(name);
		}
		System.out.println("--------------------------------------------------");
		System.out.println("---List 2 Elements");
		for (String name : list2) {
			System.out.println(name);
		}
		System.out.println("--------------------------------------------------");
		//using new to pass parameter to method printList
		
	    //The method printList(ArrayList<String>) in the type Main is not 
		//applicable for the arguments (LinkedList<String>)
		//new Main().printList(list1);
		
		//Solve the issue we can use List Interface in method (parameter)
		System.out.println("Printing the List Items -  List Interface - List 1");
		System.out.println("--------------------------------------------------");
		new Main().printList(list1);
		System.out.println("--------------------------------------------------");
		
		//Solve the issue we can use List Interface in method (parameter)
		System.out.println("Printing the List Items -  List Interface - List 2");
		System.out.println("--------------------------------------------------");
		new Main().printList(list2);
		System.out.println("--------------------------------------------------");
	}
	//Method to print where ArrayList passed as argument
	//Before ArrayList as parameter, Later changed to List<>
	 void printList(List<String> list3) {
			for (String name : list3) {
				System.out.println(name);
			}
	 }
}
