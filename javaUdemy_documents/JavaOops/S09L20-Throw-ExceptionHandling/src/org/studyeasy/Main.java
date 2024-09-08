package org.studyeasy;

public class Main {

	public static void main(String[] args) {
		Main main = new Main();
		try {
			main.doSomething();
		} catch (ZeroException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	class ZeroException extends Exception{
		
	}
	public void doSomething()throws ZeroException{
		String x = "zero";
		if(x.equals("zero")) {
			throw new ZeroException();
		}
		System.out.println("Do something");
	}
}
