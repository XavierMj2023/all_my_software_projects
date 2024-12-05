package fibonacciSeries;

import java.util.Scanner;

public class FibonacciSeries_without_recursion {

	public static void FiboWithoutRecursion() {
		// Create a Scanner object for user input
		Scanner scanner = new Scanner(System.in);

		// Ask the user for the number of terms in the Fibonacci series
		System.out.print("Enter the number of terms in the Fibonacci series: ");
		int n = scanner.nextInt();

		// Close the scanner to avoid resource leak
		scanner.close();

		// Handle edge cases
		if (n <= 0) {
			System.out.println("Please enter a positive integer greater than 0.");
		} else {
			System.out.println("Fibonacci series up to " + n + " terms:");

			// First two terms of the Fibonacci series
			int a = 0, b = 1;

			// Print the Fibonacci series
			for (int i = 1; i <= n; i++) {
				System.out.print(a + " ");

				// Update a and b for the next term
				int nextTerm = a + b;
				a = b;
				b = nextTerm;
			}
		}
	}
}
