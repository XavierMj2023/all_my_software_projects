package org.studyeasy;

import java.util.Scanner;

import org.writingcontentonfileclasses.FileHandlingReadTextFileUsingBufferedReader;
import org.writingcontentonfileclasses.FileHandlingTryWithResources;
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
			case 8:
				//FileHandling Try With Resources Test
				FileHandlingTryWithResources.FileHandlingTryWithResourcesTest();
				break;
			case 9:
				//Whenever we create an object like BufferedWriterObject and we are opening the stream for this
				//particular file there is a handle created and it is like a key to your file.
				//And you can use this key to manipulate the file, and you have to close in order to prevent
				//resource leak.
				//Whenever we make use of try with resources, Jav will close the resource by default/automatically
				//Auto Closing is optional
				FileHandlingTryWithResources.FileHandlingWritingTryWithResources_FileClosingIsOptional();
				break;
			case 10:
				//Here we are having try with resources inside try block but no closing
				//Content is disappeared because we haven't closed it.
				FileHandlingTryWithResources.FileHandlingWritingTryWithResources_TryWithResources_InsideTryBlock();
				break;
			case 11:
				//Using close in finally block
				FileHandlingTryWithResources.FileHandlingWritingTryWithResources_TryWithResources_FinallyBlock();
				break;
			case 12:
				//Read Text file using Buffered Reader
				FileHandlingReadTextFileUsingBufferedReader.FileHandlingReadTextFileUsingBufferedReaderTest();
				break;
			case 13:
				//Read Text file using Buffered Reader Demo
				//Created folder manually directly into file system and file from project
				FileHandlingReadTextFileUsingBufferedReader.FileHandlingReadTextFileUsingBufferedReaderExe_BufferedReader();
				break;
			}
		sc.close();
	}

}
