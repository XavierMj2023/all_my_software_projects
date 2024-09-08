package org.studyeasy;

public class Scope {

	private int i = 55;
	public static void main(String[] args) {
		{
			int i = 100;
			System.out.println(i);
		}
		/*
		Here the i ; we get error as soon as loop ends local variable 
		ends in loop.So (int i;)is declared at the begining
		
		System.out.println(i);
		*/
		System.out.println("****");
		System.out.println(new Scope().i);
	}

}
