package org.studyeasy;

import java.util.Scanner;

import org.javadirectory.FileHandlingCreateDirectory;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//FileHandling Create Directory Test
				FileHandlingCreateDirectory.FileHandlingDirectoryTest();
				break;
			case 2:
				//File Directory Create Demo
				FileHandlingCreateDirectory.FileHandlingDirectoryExe();
				break;
			case 3:
				//File Directory SubFolder Check
				FileHandlingCreateDirectory.FileHandlingDirectoryCreateSubFolder_Check();
				break;
			case 4:
				//File Directory SubFolder mkdirs()
				FileHandlingCreateDirectory.FileHandlingDirectoryCreateSubFolder();
				break;
			case 5:
				//File Directory SubFolder Relative Path
				FileHandlingCreateDirectory.FileHandlingDirectoryCreateSubFolder_RelativePath();
				break;
			}
		sc.close();
	}

}
