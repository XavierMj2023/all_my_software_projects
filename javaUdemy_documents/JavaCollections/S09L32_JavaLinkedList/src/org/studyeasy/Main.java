package org.studyeasy;

import java.util.LinkedList;

public class Main {

	public static void main(String[] args) {
		LinkedList<String> names = new LinkedList<>();
		names.add("Chaand");
		names.add("Jai");
		names.add("Veeru");
		names.add("Jake");
		names.add("Rachel");
		names.add("Mohini");
		System.out.println(names);//[Chaand, Jai, Veeru, Jake, Rachel, Mohini]
		//System.out.println(names[0]);//Error
		
		//Add an Element
		names.add("John");
		System.out.println(names);//[Chaand, Jai, Veeru, Jake, Rachel, Mohini, John]
		
		//Add Anywhere - In this case Position 2
		System.out.println("------------------------------------------");
		LinkedList<String> names2 = new LinkedList<>();
		names2.add("Chaand");
		names2.add("Jai");
		names2.add("Veeru");
		names2.add("Jake");
		names2.add("Rachel");
		names2.add("Mohini");
		System.out.println(names2);//[Chaand, Jai, Veeru, Jake, Rachel, Mohini]
		names2.add(2, "John");
		System.out.println(names2);//[Chaand, Jai, John, Veeru, Jake, Rachel, Mohini]
		
		System.out.println("---------Modify The Value---------------------------------");
		//Modify The Value
		LinkedList<String> names3 = new LinkedList<>();
		names3.add("Chaand");
		names3.add("Jai");
		names3.add("Veeru");
		names3.add("Jake");
		names3.add("Rachel");
		names3.add("Mohini");
		System.out.println(names3);
		
		System.out.println("---After Updating---");
		names3.set(3, "Mike");
		System.out.println(names3);
		
		System.out.println("---------Remove The Value---------------------------------");
		//Modify The Value
		LinkedList<String> names4 = new LinkedList<>();
		names4.add("Chaand");
		names4.add("Jai");
		names4.add("Veeru");
		names4.add("Jake");
		names4.add("Rachel");
		names4.add("Mohini");
		System.out.println(names4);
		
		System.out.println("---Updating Value---");
		names4.set(3, "Mike");
		System.out.println(names3);
		
		System.out.println("---Removing Value---");
		names4.remove(0);
		System.out.println(names4);
	}

}
