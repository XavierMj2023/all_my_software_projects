package org.studyeasy.shop;

//For the Solution 2 we are commenting the below code and adding new class Lock.
/*
abstract class Lock{
	public abstract boolean isUnlocked(String keyCode);
	
	public void test() {
		System.out.println("test");
	}
}
*/

public class Door {
	
	/*
	 * Object of Lock Type and Cannot Instantiate Lock Class
	 *
	 * Lock lock = new Lock(); 
	 * lock.test();
	 */
	
	 //Anonymous Inner Class
	 Lock lock = new Lock() {

		@Override
		public boolean isUnlocked(String keyCode) {
			if(keyCode.equals("qwerty")) {
				return true;
			}else {
				return false;
			}
		} 
	 };
	 
    //Want to access Anonymous Inner Class ,we need to have getter method
	public Lock getLock() {
		return lock;
	}
	 
}
