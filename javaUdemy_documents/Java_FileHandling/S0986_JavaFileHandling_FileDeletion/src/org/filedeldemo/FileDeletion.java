package org.filedeldemo;

import java.io.File;

public class FileDeletion {

	public static void FileDeletionTest() {
		System.out.println("File deletion demo");
	}
	public static void FileDeletionDemo() {
		File file = new File("testdelete//del01");
		if(file.delete()) {
			System.out.println("File deleted");
		}else {
			System.out.println("File deletion had some error!!");
		}
	}
}
