package org.studyeasy;

import java.util.Comparator;
import java.util.HashSet;
import java.util.Set;
import java.util.TreeSet;

class Data<K extends Integer,V extends String> {
	
	private K key;
	private V value;
	
	public Data(K key, V value) {
		this.key = key;
		this.value = value;
	}

	@Override
	public String toString() {
		return "Data [key=" + key + ", value=" + value + "]";
	}

	public K getKey() {
		return key;
	}

	public V getValue() {
		return value;
	}
	
}
public class Main {

	public static void main(String[] args) {
		
		//case 1
		//HashSet
		Set<Data<Integer,String>>  set = new HashSet<>();
		set.add(new Data<>(1,"Chaand"));
		set.add(new Data<>(2,"Ashyln"));
		set.add(new Data<>(3,"Mike"));
		set.add(new Data<>(4,"John"));
		set.add(new Data<>(5,"John"));
		set.add(new Data<>(1,"Chaand"));
		
		System.out.println("---This is a HashSet---");
		System.out.println("-----------------------");
		
		for (Data data: set) {
			System.out.println(data);
		}
		System.out.println("-----------------------");
		
		//case 2
		//TreeSet
		//Here you get error
		//Bacause the TreeSet likes to sort out things
		//So Use Comparator Interface
		/*
		 * Set<Data<Integer,String>> set2 = new TreeSet<>(); set2.add(new
		 * Data<>(1,"Chaand")); set2.add(new Data<>(2,"Ashyln")); set2.add(new
		 * Data<>(3,"Mike")); set2.add(new Data<>(4,"John")); set2.add(new
		 * Data<>(5,"John")); set2.add(new Data<>(1,"Chaand"));
		 * 
		 * System.out.println("---This is a TreeSet---");
		 * System.out.println("-----------------------");
		 * 
		 * for (Data data: set2) { System.out.println(data); }
		 * System.out.println("-----------------------");
		 */
		
		
		//case 3
		//TreeSet
		//Here you get error
		//Bacause the TreeSet likes to sort out things
		//So Use Comparator Interface
		
		/*
		 * CompareTo() - Used for comparing like one datatype
		 * compare()   - Used for comapring like more than one datatype
		 */
		Comparator<Data<Integer,String>> COMPARE_KEY = new Comparator<Data<Integer,String>>() {
		@Override
		public int compare(Data<Integer, String> obj1, Data<Integer, String> obj2) {
			if(obj1.getKey() < obj2.getKey()) {
				return -1;
			}
			else if(obj1.getKey() > obj2.getKey()) {
				return 1;
			}
			return 0;
		}};
		
		
		Set<Data<Integer,String>>  set3 = new TreeSet<>(COMPARE_KEY);
		set3.add(new Data<>(1,"Chaand"));
		set3.add(new Data<>(2,"Ashyln"));
		set3.add(new Data<>(3,"Mike"));
		set3.add(new Data<>(4,"John"));
		set3.add(new Data<>(5,"John"));
		set3.add(new Data<>(1,"Chaand"));
		
		//Value different but key are same
		set3.add(new Data<>(2,"Chaand"));
					
		System.out.println("---This is a TreeSet With Compartor Interface---");
		System.out.println("-----------------------");
						
		for (Data data: set3) {
			System.out.println(data);
		}
		System.out.println("-----------------------");	
	}
}
