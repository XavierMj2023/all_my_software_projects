package org.studyeasy;

import java.io.IOException;
import java.util.Scanner;

import org.filedemo.FileHandlingCreateOnDisk;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ops;
		System.out.println("Enter the number to see the operation");
		ops = sc.nextInt();
		switch(ops) {
			case 1:
				//FileHandling Create On Disk Test
				FileHandlingCreateOnDisk.FileHandlingCreateOnDiskTest();
				break;
			case 2:
				//FileHandling Create On Disk Demo
				//If we do not give complete path, it will use the existing path 
				//which is nothing but your current project.
			try {
				FileHandlingCreateOnDisk.FileHandlingCreateOnDiskDemo();
			} catch (IOException e) {
				e.printStackTrace();
			}
			break;
			case 3:
				//FileHandling Create On Disk Demo
				//If we do not give complete path, it will use the existing path 
				//which is nothing but your current project.
				//Using Relative Path
			try {
				FileHandlingCreateOnDisk.FileHandlingCreateOnDiskRelativePath();
			} catch (IOException e) {
				e.printStackTrace();
			}
			break;
			case 4:
				//Windows OS use Forward Slash
				//Other OS like Linux use Backward Slash
				//Use Double slash to symbolize slash while giving file path.
				try {
					FileHandlingCreateOnDisk.FileHandlingCreateOnDiskSymbolizeSlash();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
			case 5:
				//Windows OS use Forward Slash
				//Other OS like Linux use Backward Slash
				//Use Double slash to symbolize slash while giving file path.
				//Complete Path
				try {
					FileHandlingCreateOnDisk.FileHandlingCreateOnDiskCompletePath();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
			case 6:
				//File Name Case Sensitive and not folder name
				try {
					FileHandlingCreateOnDisk.FileHandlingCreateOnDiskCaseSensitive();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
			}
		sc.close();
	}

}
