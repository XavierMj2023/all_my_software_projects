using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.HashTable
{
	public class HashTableOps
	{
		Hashtable hash = new Hashtable();

		Hashtable hashCI = new Hashtable()
		{
			{"UK", "London"},
			{"USA", "Chicago"},
			{"India", "Mumbai"}
		};

		Hashtable hashcitiesmul = new Hashtable()
		{
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};
		public void HashTableSwitch()
		{
			Console.WriteLine("Enter The Number To execute HashTable ops");
			int dictnumopt = int.Parse(Console.ReadLine());
			switch (dictnumopt)
			{
				case 0: break;
				case 1:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Shows The Syntax Of HashTable");
					Console.WriteLine("--------------------------------------------------");
					HashTableSyntax();
					break;
				case 2:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Adding elements in HashTable");
					Console.WriteLine("--------------------------------------------------");
					HashTableSyntaxAdd();
					break;
				case 3:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Adding elements in HashTable Collection Intilaizer Syntax");
					Console.WriteLine("--------------------------------------------------");
					HashTableSyntaxAddCI();
					break;
				case 4:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Updating HashTable");
					Console.WriteLine("--------------------------------------------------");
					HashTableSyntaxUpdateCI();
					break;
			}
		}
		public void HashTableSyntax()
		{
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("Hashtable <var name> = new Hashtable();");
			Console.WriteLine("--------------------------------------------------");
		}
		public void HashTableSyntaxAdd()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in HashTable with Index Before are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (DictionaryEntry kvp in hash)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");

			//Adding Elements
			hash.Add(4, "Manga");
			hash.Add(3, "Manoj");
			hash.Add(7, "Two");
			hash.Add(6, "Two");//Duplicate value
			hash.Add(2, null);//Null Value

			//When key Value is duplicate
			try
			{
				Console.WriteLine("------------------------------------------------");
				hash.Add(6, "Manoj2");
			}
			catch (Exception er)
			{
				Console.WriteLine("Error : " + er.Message);
				Console.WriteLine("Trying to add in HashTable : When key Value is duplicate ");
			}
			try
			{
				Console.WriteLine("------------------------------------------------");
				hash.Add(89, 13);
			}
			catch (Exception er)
			{
				Console.WriteLine("Error : " + er.Message);
				Console.WriteLine("Trying to add in HashTable : When Data Type not matched ");
			}
			try
			{
				Console.WriteLine("------------------------------------------------");
				hash.Add(null, "Manga");
			}
			catch (Exception et) 
			{
				Console.WriteLine("Error : " + et.Message);
				Console.WriteLine("Trying to add in HashTable : When key Value is null ");

			}
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in HashTable with Index After are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (DictionaryEntry kvp in hash)
			{
				Console.WriteLine($"Key : {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("------------------------------------------------");
		}
		public void HashTableSyntaxAddCI()
		{
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("The Elements in Dictonary with CI are : ");
			Console.WriteLine("------------------------------------------------");

			foreach (DictionaryEntry kvp in hashCI)
			{
				Console.WriteLine($"Key (City) : {kvp.Key} ; Value (Country) : {kvp.Value}");
			}

			Console.WriteLine("-------------------------------------");
		}
		public void HashTableSyntaxUpdateCI()
		{
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Accessing HashTable Elements/Values : UK ");
			Console.WriteLine("--------------------------------------------");

			//It returns object so explicit cast
			string citiesOfUK = (string)hashcitiesmul["UK"];
			Console.WriteLine("--------------------------------------------");

			Console.WriteLine(citiesOfUK);

			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Looping through Hashtable with values");
			Console.WriteLine("--------------------------------------------");
			foreach (DictionaryEntry kvp in hashcitiesmul)
			{
				Console.WriteLine($"Key: {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("--------------------------------------------");

			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Updating HashTable Elements/Values : UK ");
			Console.WriteLine("--------------------------------------------");

			hashcitiesmul["UK"] = "PlyMouth,Oxford,Derby,Nottingham";

			string citiesOfUK2 = (string)hashcitiesmul["UK"];

			Console.WriteLine("--------------------------------------------");
			
			Console.WriteLine(citiesOfUK2);

			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Looping through Hashtable with updated values");
			Console.WriteLine("--------------------------------------------");
			foreach(DictionaryEntry kvp in hashcitiesmul) 
			{
				Console.WriteLine($"Key: {kvp.Key} ; Value : {kvp.Value}");
			}
			Console.WriteLine("--------------------------------------------");
		}
	}
}
