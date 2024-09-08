package org.studyeasy;

import java.util.Scanner;

import org.writingcontentonfileclasses.FileHandlingWritingContentOnFile;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//File Handling - File Content Write
				//Every method which deals with file operations will throw an error
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileTest();
				break;
			case 2:
				//Using - TryCatch and Buffered Writer
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileExe_BufferedWriter();
				break;
			case 3:
				//FileHandling Writing Content On File Content On File
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileContentOnFile();
				break;
			case 4:
				//Append flag set to true
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileContentOnFile_AppendFlag();
				break;
			case 5:
				//New Line method
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileContentOnFile_NewLine();
				break;
			case 6:
				//Passing file name to method instead of specifying the path
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileContentOnFile_NewLine();
				break;
			case 7:
				//FileHandling Writing Content On FileContent On File File Object To Method
				FileHandlingWritingContentOnFile.FileHandlingWritingContentOnFileContentOnFile_FileObjectToMethod();
				break;
			}
		sc.close();
	}

}
