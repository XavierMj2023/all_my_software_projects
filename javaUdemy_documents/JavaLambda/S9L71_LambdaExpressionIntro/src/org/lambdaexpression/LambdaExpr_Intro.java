package org.lambdaexpression;

import org.interfaces.Lambda;

public class LambdaExpr_Intro {

	public static void LambdaIntro() {
		
		Lambda lambda = new Lambda() {
			
			@Override
			public void demo() {
				System.out.println("Statement 01");
			}
		};
		lambda.demo();
	}
	public static void LambdaIntro_Part2() {
		
		//Lambda Expression Notation
		Lambda lambda = () -> System.out.println("Statement 02");
		
		lambda.demo();
	}
	public static void LambdaIntro_ExperimentalLambda() {
		
		//Lambda Expression Notation
		Lambda lambda = () -> System.out.println("Statement 01");
		System.out.println("Statement 02");//First executed because it is not part of lambda method it is part of LambdaIntro_ExperimentalLambda()
		lambda.demo();
	}
	public static void LambdaIntro_MultipleStatements() {
		
		//For multiple statements we have to make use of braces
		Lambda lambda = () -> {
			System.out.println("Statement 01");
			System.out.println("Statement 02");
		};
		lambda.demo();
	}
	public static void LambdaIntro_OtherPossibleNotations() {
		
		//For multiple statements we have to make use of braces
		//Closed In Parenthesis
		System.out.println("Case 1: Closed In Paranthesis");
		Lambda lambda = (() -> {
			System.out.println("Statement 01");
			System.out.println("Statement 02");
		});
		lambda.demo();
		
		System.out.println("*************************");
		
		//Closed In Parenthesis - Single statement
		System.out.println("Case 2: Closed In Paranthesis - Single statement");
		Lambda lambda2 = (() -> {System.out.println("Statement 01");});
		lambda2.demo();
	}
}
