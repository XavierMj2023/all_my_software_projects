package org.studyeasy;

/*
  T - Type
  E - Element
  K - Key
  N - Number
  V - Value
*/

/*class Data<T1,T2>{
	private T1 x;
}*/

class Data<K,V>{
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	public K getKey() {
		return key;
	}

	public V getValue() {
		return value;
	}

	@Override
	public String toString() {
		return "Data [key=" + key + ", value=" + value + "]";
	}
	
	//Generic Method
	public <E,N> void display(E element, N number) {
		System.out.println("Element: "+element+ " , Number: "+number);
	}
}
public class Main {

	public static void main(String[] args) {
		//You get error
		//Data data = new Data();
		
		//So
		Data<Integer,String> data = new Data(10, "Chaand");
		System.out.println(data);//Data [key=10, value=Chaand]
		
		//You can also do like below
		System.out.println("Key : "+data.getKey()+" ,"+"Value : "+data.getValue());
		//Key : 10 ,Value : Chaand
		
		data.display("Test", 40);//Element: Test , Number: 40
		data.display(29, 40);//Element: 29 , Number: 40
	}

}
