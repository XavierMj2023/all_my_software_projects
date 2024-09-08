package org.studyeasy;

import org.studyeasy.blog.Java;

//Conflict arises
//import org.studyeasy.platform.Java;

import org.studyeasy.platform.*;

public class App {

	public static void main(String[] args) {
		
		Java blog2 = new Java();
		blog2.usedFor();
		
		//You can also use for Class Java from package blog
//		org.studyeasy.blog.Java blog = new org.studyeasy.blog.Java();
//		blog.usedFor();
		
		//Not giving proper suggestion
		//Java platform2 = new Java();
		
		//So use
		org.studyeasy.platform.Java platform = new org.studyeasy.platform.Java();
		platform.usedFor();
	}
}
