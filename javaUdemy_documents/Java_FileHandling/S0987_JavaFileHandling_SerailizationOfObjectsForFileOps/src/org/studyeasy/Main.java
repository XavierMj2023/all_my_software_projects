package org.studyeasy;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.util.Scanner;

import org.serializeclassForSerialization.VehicleAdvanced2;
import org.serilaize.SerializationOfObjectForFileObjects_WriteObject;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//Serialization Of Objects for File Objects in Java Test
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjectsTest();
				break;
			case 2:
				//Serialization Of Objects for File Objects in Java Demo
				//It did create DAT file, but it is not serializable
				//Objects are not serializable
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjectsDemo();
				break;
			case 3:
				//Serilizable Interface
				//Exception Reason - There are so many objects and every object is writing to the same file.
				//Inconsistency and overwrite some info. Not sequentially written on the file.
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjects_SerilizableInterface();
				break;
			case 4:
				//How to read the info from the DAT file?
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile();
				break;
				
			//-------------------------------------------------------------------------------------------
			//Extra Files for Other Class for a different executation for different topics
			//-------------------------------------------------------------------------------------------
			case 5:
				//Write - SerializationOfObjectForFileObjects_ReadInfoFromDATfile_FinalVariable()
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_FinalVariable_Write();
				break;
			case 6:
				//Write - SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Write()
				SerializationOfObjectForFileObjects_WriteObject.SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Write();
				break;
			}
		sc.close();
	}

}
