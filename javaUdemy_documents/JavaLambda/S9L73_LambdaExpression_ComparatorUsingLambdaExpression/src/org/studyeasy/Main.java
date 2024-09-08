package org.studyeasy;

import java.util.Scanner;

import org.demoClassesC.LambdaComparator;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Lambda Expression Comparator Intro
				LambdaComparator.LambdaComparatorDemo();
				break;
			case 2:
				//Lambda Expression Comparator Sort
				LambdaComparator.LambdaComparatorSortDemo();
				break;
			case 3:
				//LambdaComparatorSortWithLambdaDemo
				LambdaComparator.LambdaComparatorSortWithLambdaDemo();
				break;
			case 4:
				//Lambda Expression Comparator with own logic
				LambdaComparator.LambdaComparatorSortWithLambdaWithReturn_MultipleStatements();
				break;
		}
		sc.close();
	}
}