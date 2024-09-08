package org.studyeasy.shop;

public class Door {
	
	public boolean isLocked(String key) {
		
		//Local Inner Class ; It is hidden(abstract)
		//Lock is for door and lock is dependent on Door
		//Simply receiving value from the outside world and then sending info to the local inner class
		
		class Lock{
			public boolean isLocked(String key) {
				if(key.equals("qwerty")) {
					return false;
				}else {
					return true;
				}
			}
		}
		return new Lock().isLocked(key);
	}
}
