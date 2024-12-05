package mainClass;

import java.util.Scanner;

import fibonacciSeries.FibonacciSeries_without_recursion;

public class MainClass {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);

		System.out.println("-----------------------");
		System.out.println("List Of Basic Programs");
		System.out.println("-----------------------");
		System.out.println("1:Fibonacci Series Without Recursion");


		System.out.println("-----------------------");
		System.out.println("Enter the Case No :");
		System.out.println("-----------------------");
		int n = scanner.nextInt();

		switch(n) {
		case 1:
			//Basic Program 1
			//Fibonacci Series - The next number is sum of previous 2 no
			//Without recursion
			FibonacciSeries_without_recursion.FiboWithoutRecursion();
		}

		// Close the scanner to avoid resource leak
		scanner.close();
	}
}

