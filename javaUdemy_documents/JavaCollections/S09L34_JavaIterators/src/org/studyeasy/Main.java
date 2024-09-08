package org.studyeasy;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		List<String> list2 = new ArrayList<>();
		list2.add("StudyEasy");
		list2.add("organization");
		list2.add("team");
		list2.add("Chaand");
		new Main().printList(list2);
		
		//Sort
		System.out.println("------Natural Ordering--------");
		list2.sort(null);//Natural Ordering
		System.out.println(list2);
		
		List<String> list3 = new ArrayList<>();
		list3.add("StudyEasy");
		list3.add("Organization");
		list3.add("Team");
		list3.add("chaand");
		new Main().printList(list3);
		
		System.out.println("---Natural Ordering with Capital Keys and small keys----------");
		list3.sort(null);//Natural Ordering
		System.out.println(list3);
		
		//Reverse
		System.out.println("-----Reverse Collection------");
		Collections.reverse(list3);
		System.out.println(list3);
	}
	//Method to print where ArrayList passed as argument
	//Before ArrayList as parameter, Later changed to List<>
	 void printList(List<String> list) {
		 //Iterators
		 Iterator<String> data = list.listIterator();
		 while(data.hasNext()) {
			 System.out.println(data.next());
		 }
		 //Output
		 /* 
		  * StudyEasy
			organization
			team
		  * 
		  * 
		  */
		 
		 
	 }
}
