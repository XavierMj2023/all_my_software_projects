package org.classesForTheBankScenarios_Interupt;

public class InteruptDemo {

	//Static Variable
	public static int balance = 0;

	synchronized public void withdraw(int amount) {
		if(balance <= 0) {
			System.out.println("Waiting for the amount to be updated after withdrawl of $"+amount);
			try {
				wait();
			} catch (InterruptedException e) {
				System.out.println("Withdrawl interupted");
			}
		}
		if(balance - amount < 0) {
			return ;
		}
		balance = balance - amount;
		System.out.println("The current balance is : $"+balance);
	}

	public boolean deposit(int amount) {
		synchronized (this) {
			if(amount > 0) {
				System.out.println("We are depositing the amount in the bank of sum $"+amount);
				balance = balance + amount;
				notify();
				return true;
			}else {
				System.out.println("Invalid amount"+amount);
				return false;
			}
		}
	}
}
