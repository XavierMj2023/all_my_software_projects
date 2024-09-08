package org.writingcontentonfileclasses;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class FileHandlingTryWithResources {

	public static void FileHandlingTryWithResourcesTest() {
		System.out.println("Try With Resources FH");
	}
	//This is a try with resources
	//try(BufferedWriter bw = new BufferedWriter(new FileWriter("studyeasy2//test_appendflag.txt",true))){}

	public static void FileHandlingWritingTryWithResources_FileClosingIsOptional() {

		//Creating a File Object
		File file = new File("studyeasy2//test_fileresource_close.txt");

		try(BufferedWriter bw = new BufferedWriter(new FileWriter(file,true))){
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");
			bw.close();

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
	public static void FileHandlingWritingTryWithResources_TryWithResources_InsideTryBlock() {

		//Creating a File Object - Case 1
		File file1 = new File("studyeasy3//tryWithResources_InsideTryBlock_Case 1.txt");

		//case 1: Here we are having try with resources inside try block but no closing
		System.out.println("Here we are having try with resources inside try block but no closing");
		System.out.println("----------------------------------------------------------------------");
		try{
			BufferedWriter bw = new BufferedWriter(new FileWriter(file1));
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
		System.out.println("----------------------------------------------------------------------");


		//Creating a File Object With Append Flag as true - Case 2
		File file2 = new File("studyeasy3//tryWithResources_InsideTryBlock_With_AppendFlag_Case 2.txt");

		//case 2: Here we are having try with resources inside try block but no closing with append flag as true
		System.out.println("Here we are having try with resources inside try block but no closing and append flag");
		System.out.println("----------------------------------------------------------------------");
		try{
			BufferedWriter bw = new BufferedWriter(new FileWriter(file2,true));
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
		System.out.println("----------------------------------------------------------------------");

		//Creating a File Object With Append Flag as true with close statement - Case 3
		File file3 = new File("studyeasy3//tryWithResources_InsideTryBlock_With_Close_Case 3.txt");

		//case 3: Here we are having try with resources inside try block but closing
		System.out.println("Here we are having try with resources inside try block but closing");
		System.out.println("----------------------------------------------------------------------");
		try{
			BufferedWriter bw = new BufferedWriter(new FileWriter(file3));
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");
			bw.close();

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
		System.out.println("----------------------------------------------------------------------");

		//Creating a File Object With Append Flag as true with close statement and append as true - Case 4
		File file4 = new File("studyeasy3//tryWithResources_InsideTryBlock_With_Close_And_Append_Case 4.txt");

		//case 3: Here we are having try with resources inside try block but closing
		System.out.println("Here we are having try with resources inside try block but closing and append as true");
		System.out.println("----------------------------------------------------------------------");
		try{
			BufferedWriter bw = new BufferedWriter(new FileWriter(file4,true));
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");
			bw.close();

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
		System.out.println("----------------------------------------------------------------------");
	}
	public static void FileHandlingWritingTryWithResources_TryWithResources_FinallyBlock() {

		BufferedWriter bw = null;
		try{
			bw = new BufferedWriter(new FileWriter("studyeasy4//finally_test.txt"));
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");

			System.out.println("File operation was successful");
			
		}catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}finally {
			//Not accessible - bw.close(); - So bring try with resources outside try block
			
			//After bringing it outside, FileWriter will throw an error.
			//Solution is in this method, please observe
			//Make bw variable as null
			//And keep the other half inside try block
			
			try {
				bw.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
		System.out.println("----------------------------------------------------------------------");
	}
}
