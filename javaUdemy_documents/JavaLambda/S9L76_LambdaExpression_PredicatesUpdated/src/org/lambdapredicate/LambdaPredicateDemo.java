package org.lambdapredicate;

import java.util.function.IntPredicate;

public class LambdaPredicateDemo {

	public static void LambdaPredicateDemoTest() {
		System.out.println("Hi Predicate");
	}
	public static void LambdaPredicateDemoExe() {
		IntPredicate lessThan18 = new IntPredicate() {
			
			@Override
			public boolean test(int value) {
				if(value < 18) {
					return true;
				}else {
					return false;
				}
			}
		};
		System.out.println("Value passed is 10 ;So result is : "+lessThan18.test(10));
		System.out.println("Value passed is 20 ;So result is : "+lessThan18.test(20));
	}
	public static void LambdaPredicateDemo_LambdaExpression() {
		IntPredicate lessThan18 = value -> {
			if(value < 18) {
				return true;
			}else {
				return false;
			}
		};
			
		System.out.println("Value passed is 10 ;So result is : "+lessThan18.test(10));
		System.out.println("Value passed is 20 ;So result is : "+lessThan18.test(20));
	}
	public static void LambdaPredicateDemo_LambdaExpression_Shorthand() {
		IntPredicate lessThan18 = value -> value < 18;
		System.out.println("Value passed is 10 ;So result is : "+lessThan18.test(10));
		System.out.println("Value passed is 20 ;So result is : "+lessThan18.test(20));
	}
	public static void LambdaPredicateDemo_LambdaExpression_PreBuiltCond() {
		IntPredicate lessThan18 = value -> value < 18;
		IntPredicate moreThan18 = value -> value > 18;
		
		System.out.println("With Test : "+(lessThan18).and(moreThan18).test(10));
		
		System.out.println("With Test and Negate : "+(lessThan18).and(moreThan18).negate().test(10));
		
		System.out.println("Instead of 'and' using 'or' : "+(lessThan18).or(moreThan18).negate().test(10));
	}
}
