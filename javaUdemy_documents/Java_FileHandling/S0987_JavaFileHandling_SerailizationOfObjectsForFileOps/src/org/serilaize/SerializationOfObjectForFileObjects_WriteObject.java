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

public class SerializationOfObjectForFileObjects_WriteObject {

	public static void SerializationOfObjectForFileObjectsTest() {
		System.out.println("Serialization Of Object For File Objects Test");
	}
	public static void SerializationOfObjectForFileObjectsDemo() {
		//Main Operation will be done
		Vehicle bike = new Vehicle("Bike", 52141);
		Vehicle car = new Vehicle("Car", 95824);

		//File Output Stream
		try(FileOutputStream fos = new FileOutputStream("serializeobject//VehicleDemo_Objects_Of_VehicleClass.dat")) {

			//Try to write these objects to file

			try(ObjectOutputStream obj = new ObjectOutputStream(fos) ){
				obj.writeObject(bike);
				obj.writeObject(car);

			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e1) {
			e1.printStackTrace();
		}
	}
	public static void SerializationOfObjectForFileObjects_SerilizableInterface() {
		VehicleAdvanced bike = new VehicleAdvanced("Bike", 52141);
		VehicleAdvanced car =  new VehicleAdvanced("Car", 95824);

		//File Output Stream
		try(FileOutputStream fos = new FileOutputStream("serializeobject//VehicleSerilizableInterface_Objects_Of_VehicleAdvancedClass.dat")) {

			//Try to write these objects to file

			try(ObjectOutputStream obj = new ObjectOutputStream(fos) ){
				obj.writeObject(bike);
				obj.writeObject(car);
				System.out.println("File Operation was sucessful");
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e1) {
			e1.printStackTrace();
		}
	}
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile() {

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
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_FinalVariable_Write() {
		//Main Operation will be done
		VehicleAdvanced2 bike = new VehicleAdvanced2("Bike", 52141);
		VehicleAdvanced2 car = new VehicleAdvanced2("Car", 95824);

		//File Output Stream
		try(FileOutputStream fos = new FileOutputStream("serializeobject//VehicleReadInfoFromDATfile_FinalVariable_Write_Objects_Of_VehicleAdvanced2Class.dat")) {

			//Try to write these objects to file

			try(ObjectOutputStream obj = new ObjectOutputStream(fos) ){
				obj.writeObject(bike);
				obj.writeObject(car);

			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e1) {
			e1.printStackTrace();
		}
	}
	public static void SerializationOfObjectForFileObjects_ReadInfoFromDATfile_Read_SerialID_Write() {

		Vehicle_SerialID bike = new Vehicle_SerialID("Bike", 52141);
		Vehicle_SerialID car = new Vehicle_SerialID("Car", 95824);

		//File Output Stream
		try(FileOutputStream fos = new FileOutputStream("serializeobject//VehicleReadInfoFromDATfile_SerialID_Objects_Of_Vehicle_SerialID_Class.dat")) {

			//Try to write these objects to file

			try(ObjectOutputStream obj = new ObjectOutputStream(fos) ){
				obj.writeObject(bike);
				obj.writeObject(car);
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e1) {
			e1.printStackTrace();
		}
	}
}
