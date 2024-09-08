package org.studyeasy.shop;

public class Door {
	//Object of Lock Class
	private Lock lock;
	 
	public Door() {
		lock = new Lock(true);
	}
	
	public Lock getLock() {
		return lock;
	}

	public void shopStatus() {
		if(lock.isLock()) {
			System.out.println("Shop is Closed ,Please Visit Later");
		}else {
			System.out.println("Welcome we are open.");
		}
	}
	//Inner Class
	public class Lock{
		//Local Variable in Lock Class
		private boolean lock;

		public Lock(boolean lock) {
			this.lock = lock;
		}

		public boolean isLock() {
			return lock;
		}

		public void setLock(boolean lock) {
			this.lock = lock;
		}
	}
}
