package org.filedemo;

import java.io.File;
import java.io.IOException;

public class FileHandlingCreateOnDisk {

	public static void FileHandlingCreateOnDiskTest() {
		System.out.println("File Handling");
	}
	public static void FileHandlingCreateOnDiskDemo() throws IOException {
		//To Handle the File - File
		File file = new File("studyeasy.txt");
		file.createNewFile();
		System.out.println("File created");
	}
	public static void FileHandlingCreateOnDiskRelativePath() throws IOException {
		//To Handle the File - File
		//Relative Path
		File file = new File("src/org/files/studyeasy.txt");
		file.createNewFile();
		System.out.println("File created");
	}
	public static void FileHandlingCreateOnDiskSymbolizeSlash() throws IOException {
		//To Handle the File - File
		//Relative Path
		//Use Double slash to symbolize slash while giving file path.
		File file = new File("src\\org\\files\\studyeasy2.txt");
		file.createNewFile();
		System.out.println("File created");
	}
	public static void FileHandlingCreateOnDiskCompletePath() throws IOException {
		//To Handle the File - File
		//Use Double slash to symbolize slash while giving file path.
		//Complete Path instead of relative path
		File file = new File("D:\\JavaTestFiles\\studyeasy.txt");
		file.createNewFile();
		System.out.println("File created");
	}
	public static void FileHandlingCreateOnDiskCaseSensitive() throws IOException {
		//File Name Case Sensitive and not folder name
		
		//File file = new File("D:\\javatestfiles\\StudyEasy.txt");
		  File file = new File("D:\\javatestfiles\\studyeasy.txt");
		
		file.createNewFile();
		System.out.println("File created");
	}
}
