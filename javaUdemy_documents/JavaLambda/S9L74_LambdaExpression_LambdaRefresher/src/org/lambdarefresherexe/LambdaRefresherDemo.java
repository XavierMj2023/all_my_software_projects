package org.lambdarefresherexe;

import org.interfaces.Data;
import org.interfaces.Data2;
import org.interfaces.DataFloat;
import org.interfaces.DataParameter;
import org.interfaces.DataParameterOptional;

public class LambdaRefresherDemo {

	public static void LambdaRefresherDemoExe() {
		Data data = () -> System.out.println("Statement 01");
		data.demo();
	}
	public static void LambdaRefresherDemoExe_ReturnType() {
		Data2 data = () -> 10;
		System.out.println(data.demo());
	}
	public static void LambdaRefresherDemoExe_ReturnType_FloatingPoint_Explicit() {
		Data2 data = () -> (int)10.25f;
		System.out.println(data.demo());
	}
	public static void LambdaRefresherDemoExe_ReturnType_FloatingPoint_Implicit() {
		DataFloat data = () -> 10;
		System.out.println(data.demo());
	}
	public static void LambdaRefresherDemoExe_ReturnType_MultipleStatement() {
		DataFloat data = () -> {
			System.out.println("Statement 01");
			return 10;
		};
		System.out.println(data.demo());
	}
	public static void LambdaRefresherDemoExe_ReturnType_MultipleStatement_LocalVar() {
		//j value can be accessed from inside the braces.
		int j = 25;
		DataFloat data = () -> {
			System.out.println("Statement 01 " + j);
			return 10;
		};
		System.out.println(data.demo());
	}
	public static void LambdaRefresherDemoExe_ReturnType_MultipleStatement_2_Parameters() {
		DataParameter data = (int x, float y) -> {
			System.out.println("Value of y is  : "+y);
			System.out.println("Value of x will be returned by the method");
			return x;
		};
		System.out.println(data.demo(10,25));
	}
	public static void LambdaRefresherDemoExe_ReturnType_ParameterOptional() {
		DataParameterOptional data = (x, y) -> {
			System.out.println("Value of y is  : "+y);
			System.out.println("Value of x will be returned by the method");
			return x;
		};
		System.out.println(data.demo(10,25.00f));
	}
}
