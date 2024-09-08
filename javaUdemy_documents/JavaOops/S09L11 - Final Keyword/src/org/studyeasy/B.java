package org.studyeasy;

//Child Class
public class B extends A {
	
	//Normal Variable
	private int xe = 5;
	
	//Final Variable
	//Get rid of setter method
	private final int xf = 5;
	
	//Final Variable not intialized
	//Here get rid of default constructor as it is complaining
	private final int x;

	//Parameter Constructor for property x variable
	public B(int x) {
		super();
		this.x = x;
	}

	//Getter and Setter for property x variable
	//Setter removed as we are using final
	public int getX() {
		return x;
	}
	
}
