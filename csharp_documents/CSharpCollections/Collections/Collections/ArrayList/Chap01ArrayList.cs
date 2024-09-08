using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Chap01ArrayList
{
	public class Chap01ArrayList
	{
		public static void ArrayListswitch()
		{
			int option;
			Console.WriteLine("Enter Number to perform ops :");
			option = int.Parse(Console.ReadLine());
			switch (option)
			{
				case 0: break;
				case 1:
					Console.WriteLine("---------------------------------------------------");
					Console.WriteLine("This Option shows the dynamically added values to ArrayList");
					Console.WriteLine("---------------------------------------------------");
					ArrayListOps();
					break;
				case 2:
					Console.WriteLine("-------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the dynamically added values to ArrayList using using object initializer syntax");
					Console.WriteLine("-------------------------------------------------------------------------------------------------");
					ArrayListObjectIntializerSyntax();
					break;
				case 3:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the adding an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					ArrayAddRange();
					break;
				case 4:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the accesing the element in arraylist.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					AccessElementFromArrayList();
					break;
				case 5:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the inserting the element in arraylist.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					InsertElementInArrayList();
					break;

				case 6:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the inserting the element in arraylist through InsertRange.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					InsertRangeElementInArrayList();
					break;

				case 7:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the removing the element in arraylist.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					RemoveElementInArrayList();
					break;

				case 8:
					Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("This Option shows the whether the element contains in arraylist or not.");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
					ContainElementEle();
					break;
			}
		}
		public static void ArrayListOps()
		{
			// adding elements using ArrayList.Add() method
			ArrayList arlist1 = new ArrayList();
			arlist1.Add(1);
			arlist1.Add("Bill");
			arlist1.Add(" ");
			arlist1.Add(true);
			arlist1.Add(4.5);
			arlist1.Add(null);

			// Displaying the entered data and their types in a table format
			Console.WriteLine("\nEntered data with types:");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Data | Type");
			Console.WriteLine("------------------------------------------------------------");

			for (int i = 0; i < arlist1.Count; i++)
			{
				if (arlist1[i] == null)
				{
					Console.WriteLine("| NULL \t\t| NULL");
				}
				else
				{
					Console.WriteLine($"| {arlist1[i]} \t| {arlist1[i].GetType()}");
				}
			}
			Console.WriteLine("------------------------------------------------------------");
		}

		// adding elements using object initializer syntax
		public static void ArrayListObjectIntializerSyntax()
		{
			var arlist2 = new ArrayList()
			{
				2,"Steve",null,4.5," ",true
			};
			// Displaying the entered data and their types in a table format
			Console.WriteLine("\nEntered data with types:");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Data | Type");
			Console.WriteLine("------------------------------------------------------------");

			for (int i = 0; i < arlist2.Count; i++)
			{
				if (arlist2[i] == null)
				{
					Console.WriteLine("| NULL \t\t| NULL");
				}
				else
				{
					Console.WriteLine($"| {arlist2[i]} \t| {arlist2[i].GetType()}");
				}
			}
			Console.WriteLine("------------------------------------------------------------");
		}
		public static void ArrayAddRange()
		{
			var arlist3 = new ArrayList();
			Console.WriteLine("Enter The Collection to be added");
			int optadd = int.Parse(Console.ReadLine());
			switch (optadd)
			{
				case 0: break;
				case 1:
					int[] arr = { 100, 200, 300, 400 };
					arlist3.AddRange(arr);
					Console.WriteLine("Adding Array to ArrayList");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine($"| Array  \t| {arr.GetType()}");
					Console.WriteLine($"| ArrayList  \t| {arlist3.GetType()}");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("The Contents of the array added in arraylist with the type are :");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					for (int i = 0; i < arlist3.Count; i++)
					{
						if (arlist3[i] == null)
						{
							Console.WriteLine("| NULL \t\t| NULL");
						}
						else
						{
							Console.WriteLine($"| {arlist3[i]} \t| {arlist3[i].GetType()}");
						}
					}
					Console.WriteLine();
					Console.WriteLine("------------------------------------------------------------");
					break;

				case 2:
					Queue que = new Queue();
					que.Enqueue(100);
					que.Enqueue(200);
					que.Enqueue("Smitten");
					que.Enqueue("");
					que.Enqueue(100);
					que.Enqueue(3.5);
					que.Enqueue(null);
					que.Enqueue(true);
					que.Enqueue(false);
					arlist3.AddRange(que);
					Console.WriteLine("Adding Queque to ArrayList");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine($"| Queque  \t| {que.GetType()}");
					Console.WriteLine($"| ArrayList  \t| {arlist3.GetType()}");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("The Contents of the queque added in arraylist with the type are :");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					for (int i = 0; i < arlist3.Count; i++)
					{
						if (arlist3[i] == null)
						{
							Console.WriteLine("| NULL \t\t| NULL");
						}
						else
						{
							Console.WriteLine($"| {arlist3[i]} \t| {arlist3[i].GetType()}");
						}
					}
					Console.WriteLine();
					Console.WriteLine("------------------------------------------------------------");
					break;

				case 3:
					ArrayList arlist4 = new ArrayList();
					arlist4.Add(1);
					arlist4.Add(2);
					arlist4.Add("Girgith");
					arlist4.Add("Monsoon");
					arlist4.Add("");
					arlist4.Add(true);
					arlist4.Add(null);
					arlist4.Add(45.67);
					arlist3.AddRange(arlist4);
					Console.WriteLine("Adding ArrayList to ArrayList");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine($"| Arraylist  \t| {arlist4.GetType()}");
					Console.WriteLine($"| ArrayList  \t| {arlist3.GetType()}");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("The Contents of the ArrayList added in ArrayList with the type are :");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					for (int i = 0; i < arlist3.Count; i++)
					{
						if (arlist3[i] == null)
						{
							Console.WriteLine("| NULL \t\t| NULL");
						}
						else
						{
							Console.WriteLine($"| {arlist3[i]} \t| {arlist3[i].GetType()}");
						}
					}
					Console.WriteLine();
					Console.WriteLine("------------------------------------------------------------");
					break;

				case 4:
					int[] arr2 = { 101, -200, +300, 533 };

					Queue que2 = new Queue();
					que2.Enqueue(100);
					que2.Enqueue("Smitten");
					que2.Enqueue("");
					que2.Enqueue(3.5);
					que2.Enqueue(null);
					que2.Enqueue(true);
					que2.Enqueue(false);

					var arlist5 = new ArrayList() { 68,99.34,"Jillian",null,"",false};

					arlist3.AddRange(arr2);//Adding Array
					arlist3.AddRange(que2);//Adding Queque
					arlist3.AddRange(arlist5);//Adding ArrayList

					Console.WriteLine("Adding Array,Queque and ArrayList to ArrayList");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine($"| Array  \t| {arr2.GetType()}");
					Console.WriteLine($"| Queque  \t| {que2.GetType()}");
					Console.WriteLine($"| ArrayList  \t| {arlist5.GetType()}");
					Console.WriteLine("--------------------------------------------------------------------------------------------------");
					Console.WriteLine("The Contents of the  Array,Queque and ArrayList to ArrayList added in arraylist with the type are :");
					Console.WriteLine("---------------------------------------------------------------------------------------------------");
					Console.WriteLine("\nEntered data with types:");
					Console.WriteLine("------------------------------------------------------------");
					Console.WriteLine("| Data | Type");
					Console.WriteLine("------------------------------------------------------------");
					for (int i = 0; i < arlist3.Count; i++)
					{
						if (arlist3[i] == null)
						{
							Console.WriteLine("| NULL \t\t| NULL");
						}
						else
						{
							Console.WriteLine($"| {arlist3[i]} \t| {arlist3[i].GetType()}");
						}
					}
					Console.WriteLine();
					Console.WriteLine("------------------------------------------------------------");
					break;
			}
		}
		public static void AccessElementFromArrayList()
		{
			var arr7 = new ArrayList()
			{
				26, 3.5, "Judith", "", null, 7.8
			};

			Console.WriteLine("\nEntered data with types:");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Index | Data   | Type");
			Console.WriteLine("------------------------------------------------------------");

			for (int i = 0; i < arr7.Count; i++)
			{
				object item = arr7[i];
				string itemType = (item != null) ? item.GetType().ToString() : "NULL";
				Console.WriteLine($"| {i}     | {item} \t| {itemType}");
			}

			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("Enter The Index to access element");
			int acIndex = int.Parse(Console.ReadLine());

			if (acIndex >= 0 && acIndex < arr7.Count)
			{
				object accessedElement = arr7[acIndex];
				string accessedType = (accessedElement != null) ? accessedElement.GetType().ToString() : "NULL";

				Console.WriteLine("\nElement at index and type:");
				Console.WriteLine("+--------------------------+");
				Console.WriteLine("| Index | Element   | Type ");
				Console.WriteLine("+--------------------------+");
				Console.WriteLine($"| {acIndex}     | {accessedElement} \t| {accessedType}");
				Console.WriteLine("+--------------------------+");
			}
			else
			{
				Console.WriteLine("Index is out of range.");
			}
		}
		public static void InsertElementInArrayList()
		{
			ArrayList myArrayList = new ArrayList()
			{
				10, "Hello", 3.14, true
			};

			Console.WriteLine("Current ArrayList:");
			DisplayArrayList(myArrayList);

			Console.WriteLine("\nEnter the Index to insert element:");
			int insertIndex = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Element to insert:");
			object elementToInsert = Console.ReadLine();

			if (insertIndex >= 0 && insertIndex <= myArrayList.Count)
			{
				myArrayList.Insert(insertIndex, elementToInsert);
			}
			else if (insertIndex == myArrayList.Count + 1)
			{
				// If index is exactly one beyond the last index, append the element
				myArrayList.Add(elementToInsert);
			}
			else
			{
				Console.WriteLine("Invalid index. Element cannot be inserted.");
			}

			Console.WriteLine("\nUpdated ArrayList:");
			DisplayArrayList(myArrayList);
		}
		public static void InsertRangeElementInArrayList()
		{
			ArrayList myArrayList = new ArrayList()
			{
				10, "Hello", 3.14, true
			};

			Console.WriteLine("Current ArrayList:");
			DisplayArrayList(myArrayList);

			Console.WriteLine("\nEnter the Index to insert elements:");
			int insertIndex = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Elements to insert (comma-separated):");
			string elementsInput = Console.ReadLine();

			// Splitting the input string into an array of strings
			string[] elementsToInsert = elementsInput.Split(',');

			// Creating a new ArrayList to hold the elements to be inserted
			ArrayList elementsList = new ArrayList();

			// Adding elements to the list with their respective types
			foreach (string element in elementsToInsert)
			{
				// Parsing the element to its appropriate type (you can add type checking and conversions as needed)
				if (int.TryParse(element, out int intResult))
				{
					elementsList.Add(intResult);
				}
				else if (double.TryParse(element, out double doubleResult))
				{
					elementsList.Add(doubleResult);
				}
				else if (bool.TryParse(element, out bool boolResult))
				{
					elementsList.Add(boolResult);
				}
				else
				{
					// If it's not an int, double, or bool, add it as a string
					elementsList.Add(element);
				}
			}

			// Inserting the elements at the specified index
			if (insertIndex >= 0 && insertIndex <= myArrayList.Count)
			{
				myArrayList.InsertRange(insertIndex, elementsList);
			}
			else if (insertIndex == myArrayList.Count + 1)
			{
				// If index is exactly one beyond the last index, append the elements
				myArrayList.AddRange(elementsList);
			}
			else
			{
				Console.WriteLine("Invalid index. Elements cannot be inserted.");
			}

			Console.WriteLine("\nUpdated ArrayList:");
			DisplayArrayList(myArrayList);
		}
		public static void RemoveElementInArrayList()
		{
			ArrayList myArrayList = new ArrayList()
			{
				10, "Hello", 3.14, true, 10, "World", 42
			};

			Console.WriteLine("Current ArrayList:");
			DisplayArrayList(myArrayList);

			Console.WriteLine("\nWhich operation do you want to perform?");
			Console.WriteLine("1. Remove an element");
			Console.WriteLine("2. Remove at an index");
			Console.WriteLine("3. Remove a range of elements");

			int operation = int.Parse(Console.ReadLine());

			switch (operation)
			{
				case 1:
					Console.WriteLine("\nEnter the element to remove:");
					object elementToRemove = Console.ReadLine();
					myArrayList.Remove(elementToRemove);
					break;

				case 2:
					Console.WriteLine("\nEnter the index to remove:");
					int indexToRemove = int.Parse(Console.ReadLine());
					if (indexToRemove >= 0 && indexToRemove < myArrayList.Count)
					{
						myArrayList.RemoveAt(indexToRemove);
					}
					else
					{
						Console.WriteLine("Invalid index.");
					}
					break;

				case 3:
					Console.WriteLine("\nEnter the starting index of the range to remove:");
					int startIndex = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter the number of elements to remove:");
					int count = int.Parse(Console.ReadLine());

					if (startIndex >= 0 && startIndex + count <= myArrayList.Count)
					{
						myArrayList.RemoveRange(startIndex, count);
					}
					else
					{
						Console.WriteLine("Invalid range.");
					}
					break;

				default:
					Console.WriteLine("Invalid operation.");
					break;
			}

			Console.WriteLine("\nUpdated ArrayList:");
			DisplayArrayList(myArrayList);
		}
		public static void ContainElementEle()
		{
			ArrayList myArrayList = new ArrayList()
			{
				10, "Hello", 3.14, true, 10, "World", 42
			};

			Console.WriteLine("Current ArrayList:");
			DisplayArrayList(myArrayList);

			Console.WriteLine("\nEnter the element to check if it exists in the ArrayList:");
			string elementToCheck = Console.ReadLine();

			bool containsElement = false;

			int intCheck;
			double doubleCheck;
			bool boolCheck;

			// Check if the entered element is an integer
			if (int.TryParse(elementToCheck, out intCheck))
			{
				containsElement = myArrayList.Contains(intCheck);
			}
			// Check if the entered element is a double
			else if (double.TryParse(elementToCheck, out doubleCheck))
			{
				containsElement = myArrayList.Contains(doubleCheck);
			}
			// Check if the entered element is a boolean
			else if (bool.TryParse(elementToCheck, out boolCheck))
			{
				containsElement = myArrayList.Contains(boolCheck);
			}
			// Check if the entered element is a string
			else
			{
				containsElement = myArrayList.Contains(elementToCheck);
			}

			if (containsElement)
			{
				Console.WriteLine($"The ArrayList contains the element: {elementToCheck}");
			}
			else
			{
				Console.WriteLine($"The ArrayList does not contain the element: {elementToCheck}");
			}
		}
		// Function to display ArrayList elements
		public static void DisplayArrayList(ArrayList arrayList)
		{
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Index | Data   | Type");
			Console.WriteLine("------------------------------------------------------------");

			for (int i = 0; i < arrayList.Count; i++)
			{
				object item = arrayList[i];
				string itemType = (item != null) ? item.GetType().ToString() : "NULL";
				Console.WriteLine($"| {i}     | {item} \t| {itemType}");
			}

			Console.WriteLine("------------------------------------------------------------");
		}
	}
}
