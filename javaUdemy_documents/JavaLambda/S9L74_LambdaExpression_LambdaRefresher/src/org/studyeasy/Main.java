package org.studyeasy;

import java.util.Scanner;

import org.lambdarefresherexe.LambdaRefresherDemo;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Lambda Refresher Demo
				LambdaRefresherDemo.LambdaRefresherDemoExe();
				break;
			case 2:
				//If there is a return type
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType();
				break;
			case 3:
				//If there is a return type - Floating Point Value (f) - Explicit
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_FloatingPoint_Explicit();
				break;
			case 4:
				//If there is a return type - Floating Point Value (f) - Implicit
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_FloatingPoint_Implicit();
				break;
			case 5:
				//If there is a return type - Multiple statements
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_MultipleStatement();
				break;
			case 6:
				//If there is a return type - Multiple statements - Local variable
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_MultipleStatement_LocalVar();
				break;
			case 7:
				//If there is a return type - 2 Parameters
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_MultipleStatement_2_Parameters();
				break;
			case 8:
				//If there is a return type - ParameterOptional
				LambdaRefresherDemo.LambdaRefresherDemoExe_ReturnType_ParameterOptional();
				break;
		}
		sc.close();
	}

}
