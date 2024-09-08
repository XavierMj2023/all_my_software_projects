package org.studyeasy;
import java.io.Serializable;
import java.lang.reflect.Field;

public class MySerializableClass implements Serializable {
    

    /**
	 * 
	 */
	private static final long serialVersionUID = 1187616817826721996L;

	public static void main(String[] args) {
        Class<MySerializableClass> clazz = MySerializableClass.class;
        try {
            Field serialVersionUIDField = clazz.getDeclaredField("serialVersionUID");
            long serialVersionUID = serialVersionUIDField.getLong(null);
            System.out.println("SerialVersionUID of MySerializableClass: " + serialVersionUID);
        } catch (NoSuchFieldException | IllegalAccessException e) {
            e.printStackTrace();
        }
    }
}
