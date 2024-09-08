package org.writingcontentonfileclasses;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class FileHandlingWritingContentOnFile {

	public static void FileHandlingWritingContentOnFileTest() {
		System.out.println("File Handling Writing content on file");
	}
	public static void FileHandlingWritingContentOnFileExe_BufferedWriter() {
		
		try(BufferedWriter bw = new BufferedWriter(new FileWriter("studyeasy//test.txt"))){
			bw.write("Chaand");
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
	public static void FileHandlingWritingContentOnFileContentOnFile() {
		//Using different folder name because to keep the error alive for 
		//FileHandlingWritingContentOnFileExe_BufferedWriter method
		try(BufferedWriter bw = new BufferedWriter(new FileWriter("studyeasy2//test.txt"))){
			bw.write("Author : ");
			bw.write("Manoj");
			System.out.println("File operation was successful");
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
	public static void FileHandlingWritingContentOnFileContentOnFile_AppendFlag() {
		try(BufferedWriter bw = new BufferedWriter(new FileWriter("studyeasy2//test_appendflag.txt",true))){
			bw.write("Author : ");
			bw.write("Manoj");
			System.out.println("File operation was successful");
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
	public static void FileHandlingWritingContentOnFileContentOnFile_NewLine() {
		try(BufferedWriter bw = new BufferedWriter(new FileWriter("studyeasy2//test_newline.txt",true))){
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");
			System.out.println("File operation was successful");
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
	public static void FileHandlingWritingContentOnFileContentOnFile_FileObjectToMethod() {
		
		//Creating a File Object
		File file = new File("studyeasy2//test_fileobject.txt");
		
		try(BufferedWriter bw = new BufferedWriter(new FileWriter(file,true))){
			bw.newLine();
			bw.write("Author : ");
			bw.write("Manoj");
			
			System.out.println("File operation was successful");
			
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
}
