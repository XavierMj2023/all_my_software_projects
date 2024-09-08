package org.studyeasy;

import java.util.Scanner;

import org.lambdapredicate.LambdaPredicateDemo;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Lambda Predicate Demo Test
				LambdaPredicateDemo.LambdaPredicateDemoTest();
				break;
			case 2:
				//Lambda Predicate Demo
				//Predicates are useful in test conditions
				LambdaPredicateDemo.LambdaPredicateDemoExe();
				break;
			case 3:
				//Lambda Predicate Lambda Expression form
				LambdaPredicateDemo.LambdaPredicateDemo_LambdaExpression();
				break;
			case 4:
				//Lambda Predicate Lambda Expression form -Shorthand
				LambdaPredicateDemo.LambdaPredicateDemo_LambdaExpression_Shorthand();
				break;
			case 5:
				//Lambda Predicate Lambda Expression form
				//Predicates are pre built conditions and these conditions can be concatenated
				//with logical operators as well.
				
				//Paranthesis of the left hand side is optional 
				LambdaPredicateDemo.LambdaPredicateDemo_LambdaExpression_PreBuiltCond();
				break;
		}
		sc.close();
	}

}
