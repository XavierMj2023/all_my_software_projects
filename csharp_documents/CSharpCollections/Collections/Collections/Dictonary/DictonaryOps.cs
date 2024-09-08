using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Dictonary
{
	public class DictonaryOps
	{
		IDictionary<int,string> dict1 = new Dictionary<int,string>();

		IDictionary<string,string> dict2 = new Dictionary<string, string>()
								{
									{"London", "UK"},
									{"New York", "USA"},
									{ "Mumbai", "India"},
									{"Johannesburg", "South Africa"}
								};
		 
		IDictionary<int,int> dictnos = new Dictionary<int, int>()
		 {
			 {2, 10},
			 {4, 25},
			 {1, 9},
			 {20, 7},
		 };

		public void DictonarySwitch()
		{
			Console.WriteLine("Enter The Number To execute Dictonary ops");
			int dictnumopt = int.Parse(Console.ReadLine());
			switch (dictnumopt)
			{
				case 0: break;
				case 1:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Shows The Syntax Of Dictonary");
					Console.WriteLine("--------------------------------------------------");
					DictonarySyntax();
					break;
				case 2:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Shows The Adding Values in Dictonary");
					Console.WriteLine("--------------------------------------------------");
					DictonarySyntaxAdd();
					break;
				case 3:
					Console.WriteLine("---------------------------------------------------------------------------");
					Console.WriteLine("Shows The Adding Values in Dictonary using collection-initializer syntax");
					Console.WriteLine("---------------------------------------------------------------------------");
					DictonarySyntaxAddCI();
					break;
				case 4:
					Console.WriteLine("---------------------------------------------------------------------------");
					Console.WriteLine("Shows The Added Values in Dictonary using CI :- Adding Values in CI");
					Console.WriteLine("---------------------------------------------------------------------------");
					DictonarySyntaxAddInCIString();
					break;
				case 5:
					Console.WriteLine("---------------------------------------------------------------------------");
					Console.WriteLine("Shows The Added Values in Dictonary using CI :- Adding Values in CI - Integer");
					Console.WriteLine("---------------------------------------------------------------------------");
					DictonarySyntaxAddInCIInt();
					break;
				case 6:
					Console.WriteLine("---------------------------------------------------------------------------");
					Console.WriteLine("Accessing and Setting Element Using key");
					Console.WriteLine("---------------------------------------------------------------------------");
					DictonarySyntaxAccess();
					break;
				case 7:
					Console.WriteLine("-----------------------------------------------------------------------------------------");
					Console.WriteLine("Accessing Element Using Key and Check if exist using Method - Contains()");
					Console.WriteLine("------------------------------------------------------------------------------------------");
					DictonarySyntaxAccessThroughContains();
					break;
				case 8:
					Console.WriteLine("-----------------------------------------------------------------------------------------");
					Console.WriteLine("Accessing Element Using Key and Extarcting Value using Method - TryGetValue() ");
					Console.WriteLine("------------------------------------------------------------------------------------------");
					DictonarySyntaxAccessThroughTryGetValue();
					break;
				case 9:
					Console.WriteLine("----------------------------------------");
					Console.WriteLine("Accessing Element Using ElementAt() ");
					Console.WriteLine("----------------------------------------");
					DictonaryUsingElementAt();
					break;
				case 10:
					Console.WriteLine("----------------------------------------");
					Console.WriteLine("Remove Element Using Remove() and RemoveAt() ");
					Console.WriteLine("----------------------------------------");
					DictonaryRemove();
					break;
			}
		}
		public void DictonaryRemove()
		{
			Console.WriteLine("-------------------------------------------");
			for (int i = 0; i < dict2.Count; i++)
			{
				Console.WriteLine($"Key : {dict2.ElementAt(i).Key} ; Value : {dict2.ElementAt(i).Value}");
			}
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Removing element with key value London");
			Console.WriteLine("----------------------------------------------------");
			//Removing key-value pair London
			if (dict2.Remove("London"))
			{
				Console.WriteLine("----------------------------------------------------");
				Console.WriteLine("London Key and Element is removed");
				Console.WriteLine("----------------------------------------------------");

			}
			///Clearing Dictonary
			dict2.Clear();
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Clearing Dictonary");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("-------------------------------------------");
			for (int i = 0; i < dict2.Count; i++)
			{
				Console.WriteLine($"Key : {dict2.ElementAt(i).Key} ; Value : {dict2.ElementAt(i).Value}");
			}
			Console.WriteLine("-------------------------------------------");
		}
		public void DictonaryUsingElementAt()
		{
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("Accessing Element Using ElementAt() for index 2 : " +dict2.ElementAt(2));
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("---------------------------------------------------------------------------------------");
			Console.WriteLine("Now Looping through the Dictonary and using ElementAt() with properties Key and Value");
			Console.WriteLine("---------------------------------------------------------------------------------------");
			for (int i = 0; i < dict2.Count; i++)
			{
				Console.WriteLine($"Key : {dict2.ElementAt(i).Key} ; Value : {dict2.ElementAt(i).Value}");
			}
			Console.WriteLine("----------------------------------------");
		}
		public void DictonarySyntaxAccessThroughTryGetValue()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + dict2.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			try
			{
				Console.WriteLine(dict2["Delhi"]);
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
				if (!dict2.ContainsKey("Delhi"))
				{
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("After using Contains() -:- There is no key Delhi.Dont'Worry ! It can be added to Dictonary and accessed Using TryGetValue()");
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
				}
				if (!dict2.ContainsKey("Delhi"))
				{
					dict2["Delhi"] = "Bharath(India)";
				}
				Console.WriteLine("-----------------------------------------------------------------------------------");
				Console.WriteLine("Delhi Key is added");
				Console.WriteLine("---------------------------------------------");
				Console.WriteLine("You can check whether it is added using TryGetValue()");
				Console.WriteLine("---------------------------------------------");

				// try to get value of Delhi
				if (dict2.TryGetValue("Delhi", out string res))
				{
					Console.WriteLine($"Key : Delhi ; Value :{res}");
				}
				Console.WriteLine("-----------------------------------------------------------------------------------");

				Console.WriteLine("-------------------------------");
				Console.WriteLine("Count : " + dict2.Count);
				Console.WriteLine("-------------------------------");
				Console.WriteLine();
				foreach (var kvp in dict2)
				{
					Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
				}
			}
		}
		public void DictonarySyntaxAccessThroughContains()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + dict2.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			try
			{
				Console.WriteLine(dict2["Delhi"]);
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
				if (!dict2.ContainsKey("Delhi"))
				{
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("After using Contains() -:- There is no key Delhi.Dont'Worry ! It can be added to Dictonary and accessed Using TryGetValue()");
					Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
				}
				if (!dict2.ContainsKey("Delhi"))
				{
					dict2["Delhi"] = "Bharath(India)";
				}
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Count : " + dict2.Count);
				Console.WriteLine("-------------------------------");
				Console.WriteLine();
				foreach (var kvp in dict2)
				{
					Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
				}
			}
		}
		public void DictonarySyntaxAccess()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Count : " + dict2.Count);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine("Accessing Element Through Key (Mumbai) : " + dict2["Mumbai"]);
			Console.WriteLine("--------------------------------------------------------");

			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine("Setting Element Through Key Mumbai as Bharath(India)");
			Console.WriteLine("--------------------------------------------------------");
			dict2["Mumbai"] = "Bharath(India)";
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine("Accessing Element Through Key (Mumbai) : " + dict2["Mumbai"]);
			Console.WriteLine("--------------------------------------------------------");
			try
			{
				Console.WriteLine(dict2["Delhi"]);
			}
			catch (Exception ex)
			{
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Trying to access element through Key Delhi");
				Console.WriteLine("--------------------------------------------------------");
				Console.WriteLine("Error : " + ex.Message);
				Console.WriteLine("--------------------------------------------------------");
			}
		}
		public void DictonarySyntaxAddInCIInt()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with CI Before Integer adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dictnos)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			dictnos.Add(17, 16);
			dictnos.Add(8, 56);

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with CI After Integer adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dictnos)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void DictonarySyntaxAddInCIString()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with CI Before adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			dict2.Add("Kian Chi", "Vietnam");
			dict2.Add("British Columbia", "Canada");

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictoanry with CI After adding are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void DictonarySyntaxAddCI()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with CI are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dict2)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void DictonarySyntaxAdd()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with Index Before are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dict1)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			//Adding Elements
			dict1.Add(4, "Manga");
			dict1.Add(3, "Manoj");
			dict1.Add(7, "Two");
			dict1.Add(6, "Two");//Duplicate value
			dict1.Add(2, null);//Null Value

			//dict1.Add(2, 3);//Error because value has to be string type - Compile Time Error
			//dict1.Add(null, "Manga");//Error because key has to be int type - Compile Time Error - It is null

			//When key Value is duplicate
			try
			{
				Console.WriteLine("------------------------------------------------");
				dict1.Add(6, "Manoj2");
			}
			catch (Exception er)
			{
				Console.WriteLine("Error : " + er.Message);
				Console.WriteLine("Trying to add in dictonary : When key Value is duplicate ");
			}

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with Index After are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (var kvp in dict1)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("------------------------------------------------");
		}
		public void DictonarySyntax()
		{
			Console.WriteLine("----------------------------------------------------------------------------------------------------");
			Console.WriteLine("IDictionary<datatype key, datatype value> <var_name> = new Dictionary<datatype key, datatype value>();");
			Console.WriteLine("----------------------------------------------------------------------------------------------------");
		}
	}
}
