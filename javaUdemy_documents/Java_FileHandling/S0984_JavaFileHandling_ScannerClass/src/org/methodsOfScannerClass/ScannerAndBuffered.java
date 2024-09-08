package org.methodsOfScannerClass;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class ScannerAndBuffered {

	public static void ScannerDemo() {
		try(Scanner sc = new Scanner(new File("scannerdemo//scannerdemo_text.txt"))) {
			String line;
			while(sc.hasNext()) {
				line = sc.nextLine();
				System.out.println(line);
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
	}
}
