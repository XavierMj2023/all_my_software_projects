package org.javadirectory;

public class FileHandlingCheckOS {

	public static void FileHandlingDirectoryTest() {
		System.out.println("File Check OS");
	}
	public static void FileHandlingCheckOSExe() {
		String OS = System.getProperty("os.name");//Windows 11
		System.out.println(OS);
	}
	public static void FileHandlingCheckOS_Condition() {
		String OS = System.getProperty("os.name").toLowerCase();
		System.out.println(OS);
		
		if(OS.indexOf("win") >= 0){
			System.out.println("Windows");
		}else if(OS.indexOf("mac") >= 0){
			System.out.println("Apple System");
		}else if(OS.indexOf("nix") >= 0 || OS.indexOf("nux") >= 0 || OS.indexOf("aix") >= 0){
			System.out.println("Linux/Unix system");
		}else {
			System.out.println("Unknown OS");
		}
	}
}
