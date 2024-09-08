package org.studyeasy;

import java.util.Scanner;

import org.studyclassgroup.Set_BinarySearch_ConvertToList;
import org.studyclassgroup.Set_Using_CustomObject;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Sets - Binary Search and Convert to List
				Set_BinarySearch_ConvertToList.ConvertToList();
				break;
			case 2:
				//Sets - Binary Search and Convert to List and Sort
				Set_BinarySearch_ConvertToList.ConvertToListAndSort();
				break;
			case 3:
				//Binary Search
				Set_BinarySearch_ConvertToList.BinarySearch();
				break;
			case 4:
				//Custom Object Binary Search
				Set_Using_CustomObject.Set_UsingCustomObject();
			}
		sc.close();
	}

}
