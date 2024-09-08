package org.studyeasy;

public enum Learning {
	//COREJAVA,COLLECTIONS,GENERICS,JSP,SERVLETS,MUILTITHREADING
	
	//Value variable in enum
	COREJAVA(10),COLLECTIONS(20),GENERICS(30),JSP(40),SERVLETS(50),MUILTITHREADING(60);

	private int i;
	
	Learning(int i) {
		this.i=i;
	}

	public int getI() {
		return i;
	}
	
	
}
