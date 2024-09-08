package org.studyeasy;

import java.util.Scanner;

import org.classForForEachLoop.LambdaForEachLoopDemo;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Lambda with ForEach loop Demo
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe();
				break;
			case 2:
				//Lambda with ForEach loop Demo - Enhanced Way Of Handling
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe_EnhancedWayOfHandling();
				break;
			case 3:
				//Lambda with ForEach loop Demo - Custom Object
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe_CustomObject();
				break;
			case 4:
				//Lambda with ForEach loop Demo - Custom Object - Getter
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe_CustomObject_Getter();
				break;
			case 5:
				//Lambda with ForEach loop Demo - Custom Object - Getter - Braces
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe_CustomObject_Getter_Braces();
				break;
			case 6:
				//Lambda with ForEach loop Demo - Custom Object - Getter - Braces - Condition
				LambdaForEachLoopDemo.LambdaForEachLoopDemoExe_CustomObject_Getter_Braces_Condition();
				break;
		}
		sc.close();
	}

}
