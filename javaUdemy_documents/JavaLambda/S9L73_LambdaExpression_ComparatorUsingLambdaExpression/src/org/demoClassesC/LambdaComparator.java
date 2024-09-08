package org.demoClassesC;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import org.classesForLambdaComparator.Data;

public class LambdaComparator {

	public static void LambdaComparatorDemo() {
		
		List<Data> list = new ArrayList<>();
		list.add(new Data("Chaand"));
		list.add(new Data("Ed"));
		list.add(new Data("Gia"));
		list.add(new Data("John"));
		list.add(new Data("Pooja"));
		
		for(Data temp: list) {
			System.out.println(temp);
		}
	}
	public static void LambdaComparatorSortDemo() {
		
		List<Data> list = new ArrayList<>();
		list.add(new Data("John"));
		list.add(new Data("Gia"));
		list.add(new Data("Chaand"));
		list.add(new Data("Pooja"));
		list.add(new Data("Ed"));
		
		Collections.sort(list, new Comparator<Data>() {

			@Override
			public int compare(Data o1, Data o2) {
				return o1.getName().compareTo(o2.getName());
			}
		});
		
		for(Data temp: list) {
			System.out.println(temp);
		}
	}
	public static void LambdaComparatorSortWithLambdaDemo() {
		
		List<Data> list = new ArrayList<>();
		list.add(new Data("John"));
		list.add(new Data("Gia"));
		list.add(new Data("Chaand"));
		list.add(new Data("Pooja"));
		list.add(new Data("Ed"));
		
		System.out.println("LambdaComparator Sort With Lambda Demo");
		
		//We need not to specify type in Lmabda
		Collections.sort(list, (o1,o2) -> o1.getName().compareTo(o2.getName()));
		
		for(Data temp: list) {
			System.out.println(temp);
		}
	}
	public static void LambdaComparatorSortWithLambdaWithReturn_MultipleStatements() {
		
		List<Data> list = new ArrayList<>();
		list.add(new Data("John"));
		list.add(new Data("Gia"));
		list.add(new Data("Chaand"));
		list.add(new Data("Pooja"));
		list.add(new Data("Ed"));
		
		System.out.println("Lambda Expression Comparator with own logic");
		
		//We need not to specify type in Lambda
		Collections.sort(list,(o1,o2) -> {
			
			if(o1.getName().length() < o2.getName().length()){
				return -1;
			}else if(o1.getName().length() > o2.getName().length()) {
				return 1;
			}else {
				return 0;
			}
		});
		
		for(Data temp: list) {
			System.out.println(temp);
		}
	}
}
