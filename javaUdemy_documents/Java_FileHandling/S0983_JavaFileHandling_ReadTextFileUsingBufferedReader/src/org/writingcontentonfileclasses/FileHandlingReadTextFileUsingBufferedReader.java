package org.writingcontentonfileclasses;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class FileHandlingReadTextFileUsingBufferedReader {

	public static void FileHandlingReadTextFileUsingBufferedReaderTest() {
		System.out.println("File Reader Text using Buffered Reader");
	}
	public static void FileHandlingReadTextFileUsingBufferedReaderExe_BufferedReader() {
		//Creating a File Object
		File file = new File("filereaderbr//readfiletest.txt");

		try(BufferedReader br = new BufferedReader(new FileReader(file))){
			
			String line;
			while((line = br.readLine())!= null){
				System.out.println(line);
			}

			System.out.println("File operation was successful");

		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("Something went wrong");
		}
	}
}
