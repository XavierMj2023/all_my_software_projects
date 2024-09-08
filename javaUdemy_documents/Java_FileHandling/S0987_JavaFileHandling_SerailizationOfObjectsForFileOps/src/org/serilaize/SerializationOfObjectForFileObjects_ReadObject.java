package org.serilaize;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

import org.serializeclassForSerialization.Vehicle;
import org.serializeclassForSerialization.VehicleAdvanced;
import org.serializeclassForSerialization.VehicleAdvanced2;
import org.serializeclassForSerialization.Vehicle_SerialID;

public class SerializationOfObjectForFileObjects_ReadObject {

	public static void SerializationOfObjectForFileObjectsTest() {
		System.out.println("Serialization Of Object For File Objects - Read Object - Test");
	}
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Demo() {

		try(FileInputStream fis = new FileInputStream("serializeobject//VehicleSerilizableInterface_Objects_Of_VehicleAdvancedClass.dat")) {

			try(ObjectInputStream obj = new ObjectInputStream(fis)){

				VehicleAdvanced v1 = (VehicleAdvanced)obj.readObject();
				VehicleAdvanced v2 = (VehicleAdvanced)obj.readObject();
				System.out.println(v1);
				System.out.println(v2);

			}catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		}

	}
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_FinalVariable_Read() {

		try(FileInputStream fis = new FileInputStream("serializeobject//VehicleReadInfoFromDATfile_FinalVariable_Write_Objects_Of_VehicleAdvanced2Class.dat")) {

			try(ObjectInputStream obj = new ObjectInputStream(fis)){

				VehicleAdvanced2 v1 = (VehicleAdvanced2)obj.readObject();
				VehicleAdvanced2 v2 = (VehicleAdvanced2)obj.readObject();
				System.out.println(v1);
				System.out.println(v2);

			}catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		}

	}

	//Case 1:- Trying to use Private long serial ID
	//Case 2:- Trying to increase by 1 for serial ID and then we get error

	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Read_Case1() {
		System.out.println("----------Case 1:- Trying to use Private long serial ID------------");
		System.out.println("-------------------------------------------------------------------");

		try(FileInputStream fis = new FileInputStream("serializeobject//VehicleReadInfoFromDATfile_SerialID_Objects_Of_Vehicle_SerialID_Class.dat")) {

			try(ObjectInputStream obj = new ObjectInputStream(fis)){

				Vehicle_SerialID v1 = (Vehicle_SerialID)obj.readObject();
				Vehicle_SerialID v2 = (Vehicle_SerialID)obj.readObject();
				System.out.println(v1);
				System.out.println(v2);

			}catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		}
	}
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Read_Case2() {
		System.out.println("----------Case 2:- Trying to increase by 1 for serial ID and then we get error------------");
		System.out.println("------------------------------------------------------------------------------------------");

		try(FileInputStream fis = new FileInputStream("serializeobject//VehicleReadInfoFromDATfile_SerialID_Objects_Of_Vehicle_SerialID_Class.dat")) {

			try(ObjectInputStream obj = new ObjectInputStream(fis)){

				Vehicle_SerialID v1 = (Vehicle_SerialID)obj.readObject();
				Vehicle_SerialID v2 = (Vehicle_SerialID)obj.readObject();
				System.out.println(v1);
				System.out.println(v2);

			}catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		}
	}
}
