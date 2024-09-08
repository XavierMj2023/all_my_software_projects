package org.studyeasy;

import java.util.Scanner;

import org.serilaize.SerializationOfObjectForFileObjects_ReadObject;

public class ReadObject {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
		case 1:
			//Another Main Method - Read Object Test
			SerializationOfObjectForFileObjects_ReadObject.SerializationOfObjectForFileObjectsTest();
			break;
		case 2:
			SerializationOfObjectForFileObjects_ReadObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Demo();
			break;
		case 3:
			//How to read the info from the DAT file? Making Variables of Vehicle Class final
			//Error - Because there is a minor change.
			//Java will inject this particular field, which is serial version ID, and it will assign 
			//a random number to your class.
			//And if there is any change in the class, and we want to use the objects which are there in the
			//file,but there is a change in the class, the Java will actually throw an error for it.
			//Now the error is invalid class exception and this is unchecked exception.
			
			//You are not getting any error because there is no modifications.
			//So any modifications made, you need to keep updating SerialID value else you get error.
			SerializationOfObjectForFileObjects_ReadObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_FinalVariable_Read();
			break;
		case 4:
			//Case 1:- Trying to use Private long serial ID
			SerializationOfObjectForFileObjects_ReadObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Read_Case1();
			break;
		case 5:
			//Case 2:- Trying to increase by 1 for serial ID and then we get error.
			//Try to change the value of serialId of 'Vehicle_SerialID Class' by 1 -> you get error.
			SerializationOfObjectForFileObjects_ReadObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Read_Case2();
			break;
		}
		sc.close();
	}

}
