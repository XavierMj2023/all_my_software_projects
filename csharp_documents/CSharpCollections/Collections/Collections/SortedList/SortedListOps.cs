using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.SortedList
{
	public class SortedListOps
	{
		SortedList<int, string> sortlist1 = new SortedList<int, string>();

		//Collection Intializer Syntax
		SortedList<string, string> cities = new SortedList<string, string>()
									{
										{"London", "UK"},
										{"New York", "USA"},
										{ "Mumbai", "India"},
										{"Johannesburg", "South Africa"}
									};

		SortedList<int, int> evenumbers = new SortedList<int, int>()
									{
										{9,10},
										{4,6},
										{6,8},
										{3,2}
									};
		public void SortedListSwitch()
		{
			Console.WriteLine("Enter The Number To execute SortedList ops");
			int sortnumopt = int.Parse(Console.ReadLine());
			switch (sortnumopt) 
			{ 
				case 0:break;
				case 1:Console.WriteLine("--------------------------------------------------");
					   Console.WriteLine("Shows The Syntax Of Sorted List");
					   Console.WriteLine("--------------------------------------------------");	
					   SortedListSyntax();
					   break;
				case 2:Console.WriteLine("--------------------------------------------------");
					   Console.WriteLine("Shows The Adding Values in Sorted List");
					   Console.WriteLine("--------------------------------------------------");	
					   SortedListSyntaxAdd();
					   break;
				case 3:Console.WriteLine("---------------------------------------------------------------------------");
					   Console.WriteLine("Shows The Adding Values in Sorted List using collection-initializer syntax");
					   Console.WriteLine("---------------------------------------------------------------------------");
					   SortedListSyntaxAddCI();
					   break;
				case 4:
					   Console.WriteLine("---------------------------------------------------------------------------");
					   Console.WriteLine("Shows The Added Values in Sorted List using CI :- Adding Values in CI");
					   Console.WriteLine("---------------------------------------------------------------------------");
					   SortedListSyntaxAddInCIString();
					   break;
				case 5:
					   Console.WriteLine("---------------------------------------------------------------------------");
					   Console.WriteLine("Shows The Added Values in Sorted List using CI :- Adding Values in CI - Integer");
					   Console.WriteLine("---------------------------------------------------------------------------");
					   SortedListSyntaxAddInCIInt();
					   break;
				case 6:
					   Console.WriteLine("---------------------------------------------------------------------------");
					   Console.WriteLine("Accessing and Setting Element Using key");
					   Console.WriteLine("---------------------------------------------------------------------------");
					   SortedListSyntaxAccess();
					   break;
				case 7:
					   Console.WriteLine("-----------------------------------------------------------------------------------------");
					   Console.WriteLine("Accessing Element Using Key and Check if exist using Method - Contains()");
					   Console.WriteLine("------------------------------------------------------------------------------------------");
					   SortedListSyntaxAccessThroughContains();
					   break;
				case 8:
					   Console.WriteLine("-----------------------------------------------------------------------------------------");
					   Console.WriteLine("Accessing Element Using Key and Extarcting Value using Method - TryGetValue() ");
					   Console.WriteLine("------------------------------------------------------------------------------------------");
					   SortedListSyntaxAccessThroughTryGetValue();
					   break;
				case 9:
					   Console.WriteLine("----------------------------------------");
					   Console.WriteLine("Accessing Element Using Keys and Values Properties ");
					   Console.WriteLine("----------------------------------------");
					   SortedListUsingKeysAndValuesProperties();
					   break;
				case 10:
					   Console.WriteLine("----------------------------------------");
					   Console.WriteLine("Remove Element Using Remove() and RemoveAt() ");
					   Console.WriteLine("----------------------------------------");
					   SortedListRemove();
					   break;
			}
		}
		public void SortedListRemove()
		{
			Console.WriteLine("-------------------------------------------");
			for (int i = 0; i < cities.Count; i++)
			{
				Console.WriteLine($"Key : {cities.Keys[i]} ; Value : {cities.Values[i]}");
			}
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Removing element with key value London");
			Console.WriteLine("----------------------------------------------------");
			//Removing key-value pair London
			if(cities.Remove("London"))
			{
				Console.WriteLine("----------------------------------------------------");
				Console.WriteLine("London Key and Element is removed");
				Console.WriteLine("----------------------------------------------------");

			}
			///Removing Key-Value pair from index 0
			cities.RemoveAt(0);
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Removing Key-Value pair from index 0");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("-------------------------------------------");
			for (int i = 0; i < cities.Count; i++)
			{
				Console.WriteLine($"Key : {cities.Keys[i]} ; Value : {cities.Values[i]}");
			}
			Console.WriteLine("-------------------------------------------");
		}
		public void SortedListUsingKeysAndValuesProperties()
		{
			Console.WriteLine("----------------------------------------");
			for (int i = 0;i<cities.Count;i++) 
			{
				Console.WriteLine($"Key : {cities.Keys[i]} ; Value : {cities.Values[i]}");
			}
			Console.WriteLine("----------------------------------------");
		}
		public void SortedListSyntaxAccessThroughTryGetValue()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + cities.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach (var kvp in cities)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			try
			{
				Console.WriteLine(cities["Delhi"]);
			}
			catch (Exception ex)
			{
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Trying to access element through Key Delhi");
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Error : " + ex.Message);
				Console.WriteLine("--------------------------------------------------------");
			}
			finally
			{
				Console.WriteLine("-----------------------------------------------------------------------------------");
				Console.WriteLine("So The solution is first we check whether element exists or not using Contains()");
				Console.WriteLine("-----------------------------------------------------------------------------------");
				if (!cities.ContainsKey("Delhi"))
				{
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("After using Contains() -:- There is no key Delhi.Dont'Worry ! It can be added to Sorted List and accessed Using TryGetValue()");
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
				}
				if (!cities.ContainsKey("Delhi"))
				{
					cities["Delhi"] = "Bharath(India)";
				}
				Console.WriteLine("-----------------------------------------------------------------------------------");
				Console.WriteLine("Delhi Key is added");
				Console.WriteLine("---------------------------------------------");
				Console.WriteLine("You can check whether it is added using TryGetValue()");
				Console.WriteLine("---------------------------------------------");

				// try to get value of Delhi
				if (cities.TryGetValue("Delhi",out string res))
				{
					Console.WriteLine($"Key : Delhi ; Value :{res}");
				}
				Console.WriteLine("-----------------------------------------------------------------------------------");

				Console.WriteLine("-------------------------------");
				Console.WriteLine("Count : " + cities.Count);
				Console.WriteLine("-------------------------------");
				Console.WriteLine();
				foreach (var kvp in cities)
				{
					Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
				}
			}
		}
		public void SortedListSyntaxAccessThroughContains()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + cities.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach (var kvp in cities)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			try
			{
				Console.WriteLine(cities["Delhi"]);
			}
			catch (Exception ex)
			{
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Trying to access element through Key Delhi");
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Error : " + ex.Message);
				Console.WriteLine("--------------------------------------------------------");
			}
			finally
			{
				Console.WriteLine("-----------------------------------------------------------------------------------");
				Console.WriteLine("So The solution is first we check whether element exists or not using Contains()");
				Console.WriteLine("-----------------------------------------------------------------------------------");
				if(!cities.ContainsKey("Delhi")) 
				{
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("After using Contains() -:- There is no key Delhi.Dont'Worry ! It can be added to Sorted List and accessed Using TryGetValue()");
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
				}
				if(!cities.ContainsKey("Delhi"))
				{
					cities["Delhi"] = "Bharath(India)";
				}
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Count : " + cities.Count);
				Console.WriteLine("-------------------------------");
				Console.WriteLine();
				foreach (var kvp in cities)
				{
					Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
				}
			}
		}
		public void SortedListSyntaxAccess()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + cities.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach(var kvp in cities) 
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine("Accessing Element Through Key (Mumbai) : " + cities["Mumbai"]);
			Console.WriteLine("--------------------------------------------------------");

			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine("Setting Element Through Key Mumbai as Bharath(India)");
			Console.WriteLine("--------------------------------------------------------");
			cities["Mumbai"] = "Bharath(India)";
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine("Accessing Element Through Key (Mumbai) : " + cities["Mumbai"]);
			Console.WriteLine("--------------------------------------------------------");
			try
			{
				Console.WriteLine(cities["Delhi"]);
			}
			catch (Exception ex) 
			{
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Trying to access element through Key Delhi");
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Error : "+ex.Message);
				Console.WriteLine("--------------------------------------------------------");
			}
		}
		public void SortedListSyntaxAddInCIInt()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with CI Before Integer adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in evenumbers)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			evenumbers.Add(1, 16);
			evenumbers.Add(18, 56);

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with CI After Integer adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in evenumbers)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void SortedListSyntaxAddInCIString()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with CI Before adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in cities)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			cities.Add("Kian Chi", "Vietnam");
			cities.Add("British Columbia", "Canada");

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with CI After adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in cities)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void SortedListSyntaxAddCI()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with CI are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in cities)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void SortedListSyntaxAdd()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with Index Before are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in sortlist1)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			} 

			Console.WriteLine("-------------------------------------");

			//Adding Elements
			sortlist1.Add(4, "Manga");
			sortlist1.Add(3, "Manoj");
			sortlist1.Add(7, "Two");
			sortlist1.Add(6, "Two");//Duplicate value
			sortlist1.Add(2, null);//Null Value

			//sortlist1.Add(2, 3);//Error because value has to be string type - Compile Time Error
			//sortlist1.Add(null, "Manga");//Error because key has to be int type - Compile Time Error - It is null

			//When key Value is duplicate
			try
			{
				Console.WriteLine("------------------------------------------------");
				sortlist1.Add(6, "Manoj2");
			}
			catch (Exception er)
			{
				Console.WriteLine ("Error : "+er.Message);
				Console.WriteLine("Trying to add in sortedlist : When key Value is duplicate ");
			}

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in SortedList with Index After are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in sortlist1)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("------------------------------------------------");
		}
		public void SortedListSyntax()
		{
			Console.WriteLine("----------------------------------------------------------------------------------------------------");
			Console.WriteLine("SortedList<datatype key, datatype value> <var_name> = new SortedList<datatype key, datatype value>();");
			Console.WriteLine("----------------------------------------------------------------------------------------------------");
		}
	}
}
