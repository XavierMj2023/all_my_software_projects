package org.studyeasy;

import java.util.Scanner;

import org.lambdaexpression.LambdaExpr_Intro;
import org.lambdaexpression.LambdaThread;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Lambda Expression with Interface Lambda Introduction
				LambdaExpr_Intro.LambdaIntro();
				break;
			case 2:
				//Lambda Expression gives us the shorthand expression 
				//which can replace all of these statements and modify the statements
				//in a very simple notation.
				LambdaExpr_Intro.LambdaIntro_Part2();
				break;
			case 3:
				//Lambda expression experimental
				LambdaExpr_Intro.LambdaIntro_ExperimentalLambda();
				break;
			case 4:
				//Multiple statements Lambda Expression
				LambdaExpr_Intro.LambdaIntro_MultipleStatements();
				break;
			case 5:
				//Other possible notations
				LambdaExpr_Intro.LambdaIntro_OtherPossibleNotations();
				break;
			case 6:
				//Error
				//Functional Interface is a interface having only one method.
				LambdaThread.LambdaThread_MultipleMethodsInInterface_SameMethod();
				break;
			case 7:
				//Lambda Thread
				LambdaThread.LambdaThread_MultipleMethodsInInterface_Thread();
				break;
			case 8:
				//Simplified version of Thread and Lambda
				LambdaThread.LambdaThread_MultipleMethodsInInterface_SimplifiedThread();
				break;
			}
		sc.close();
	}

}