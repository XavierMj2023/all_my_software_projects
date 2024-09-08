package org.classesForTheBankScenarios;

public class BankMethods {
	
		//Static Variable
		public static int balance = 0;
		
		public void withdraw(int amount) throws InterruptedException {
			if(balance <= 0) {
				System.out.println("Waiting for the amountto be updated after withdrawl of $"+amount);
				//We will wait for 3000ms.
				wait(3000);
			}
			balance = balance - amount;
			System.out.println("The current balance is : "+balance);
		}
		
		public void deposit(int amount) {
			System.out.println("We are depositing the amount in the bank of sum $"+amount);
			balance = balance+amount;
		}
}
