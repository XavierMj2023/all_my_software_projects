package org.javadirectory;

import java.io.File;

public class FileHandlingCreateDirectory {

	public static void FileHandlingDirectoryTest() {
		System.out.println("File directory");
	}
	public static void FileHandlingDirectoryExe() {
		File file = new File("test folder");
		//Make directory
		if(file.mkdir()) {
			System.out.println("Folder created");
		}else {
			System.out.println("Folder already exists");
		}
		//Try running again, it won't create a dictonary or folder 
		//It will just check if it there or not.
	}
	public static void FileHandlingDirectoryCreateSubFolder_Check() {
		File file = new File("test folder\\sub_testfolder\\sub_of_subtestfolder");
		//Make directory
		if(file.mkdir()) {
			System.out.println("Folder created");
		}else {
			System.out.println("Folder already exists");
		}
		//So make use of mkdirs()
	}
	public static void FileHandlingDirectoryCreateSubFolder() {
		File file = new File("test folder2\\sub_testfolder2\\sub_of_subtestfolder2");
		//Make directory
		if(file.mkdirs()) {
			System.out.println("Folder created");
		}else {
			System.out.println("Folder already exists");
		}
	}
	public static void FileHandlingDirectoryCreateSubFolder_RelativePath() {
		File file = new File("d:\\test folderjava\\sub_testfolderjava\\sub_of_subtestfolderjava");
		//Make directory
		if(file.mkdirs()) {
			System.out.println("Folder created");
		}else {
			System.out.println("Folder already exists");
		}
	}
}
