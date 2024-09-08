using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Collections.DataElements;

namespace Collections.List
{
    public class ListOps
    {
        List<int> primeNumbers = new List<int>();
        List<string> vstr = new List<string>();

        //Array With No Size : Error : CS1586: Array creation must have array size or array initializer

        //string[] cities = new string[];


        string[] cities = new string[3] { "Mumbai", "London", "New York" };

        List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };

        public void ListOpsSwitch()
        {
            Console.WriteLine("Enter The Number to do ListOp");
            int listopno = int.Parse(Console.ReadLine());
            switch (listopno)
            {
                case 0: break;
                case 1:
                    Console.WriteLine("The List elements are :");
                    ListAddInt();
                    break;
                case 2:
                    Console.WriteLine("The List elements of string are : ");
                    ListAddString();
                    break;
                case 3:
                    Console.WriteLine("Adding elements using collection initializer syntax");
                    AddElementUsingCI();
                    break;
                case 4:
                    Console.WriteLine("Adding elements using object intializer syntax");
                    AddElementUsingOI();
                    break;
                case 5:
                    Console.WriteLine("Adding Collection to the List");
                    AddCOLL();
                    break;
                case 6:
                    Console.WriteLine("Accessing List through Index");
                    AccessIndexEleList();
                    break;
                case 7:
                    Console.WriteLine("Accessing List through foreach linq method");
                    AccessForEachLINQMethodEleList();
                    break;
                case 8:
                    Console.WriteLine("Accessing List through foreach linq method (Object Intializer Syntax");
                    AccessLINQEleListOI();
                    break;
                case 9:
                    Console.WriteLine("Insert element in List");
                    InsertEle();
                    break;
                case 10:
                    Console.WriteLine("Remove Element in List");
                    RemoveEle();
                    break;
                case 11:
                    Console.WriteLine("Checking Specified Element is there or not");
                    IsElementContainInlistOrNot();
                    break;
            }
        }
        public void IsElementContainInlistOrNot()
        {
            //Ternary Operator -Shorthand if else
            var isNumber5ThereOrNot = numbers.Contains(5) ? "5 Number is there in List" : "Invalid Element";
            Console.WriteLine(isNumber5ThereOrNot);
        }
        public void RemoveEle()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index Before are : ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
            }
            Console.WriteLine("-------------------------------------");
            //Remove Element
            numbers.Remove(8);
            //Remove Element at the specified index
            numbers.RemoveAt(2);


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index After are : ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index After looking index 100 are : ");
            Console.WriteLine("-------------------------------------");
            try
            {
                numbers.RemoveAt(100);
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index After looking element 100 are : ");
            Console.WriteLine("-------------------------------------");
            try
            {
                numbers.Remove(100);
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
        public void InsertEle()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index Before are : ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
            }
            Console.WriteLine("-------------------------------------");
            //Insert Element at the End
            numbers.Insert(6, 56);
            //Insert Element at the Start
            numbers.Insert(0, 23);
            //Insert Element at the Middle
            numbers.Insert(3, 26);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Elements with Index After are : ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index : {i} ; Element : {numbers[i]}");
            }
            Console.WriteLine("-------------------------------------");
        }
        public void AccessLINQEleListOI()
        {
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"},
                new Student(){ Id = 5, Name="Bill"}
            };
            var listres = from stud in students
                          where stud.Name == "Bill"
                          select stud;

            Console.WriteLine("Get All Students where studentname is Bill");
            foreach (var stulist in listres)
            {
                Console.WriteLine($"Id : {stulist.Id} , Name : {stulist.Name}");
            }
        }
        public void AccessForEachLINQMethodEleList()
        {
            Console.WriteLine("------------------------------");
            numbers.ForEach(num => Console.Write(num + ","));
            Console.WriteLine();
            Console.WriteLine("------------------------------");
        }
        public void AccessIndexEleList()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + numbers.Count);

            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index {i} ; Element is {numbers[i]}");
            }
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Accessing Through Index 3");
                    Console.WriteLine($"Index {i} ; Element is {numbers[i]}");
                }
            }
            Console.WriteLine("-------------------------------");
        }
        public void AddCOLL()
        {
            var popcity = new List<string>();
            popcity.AddRange(cities);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + popcity.Count);

            Console.WriteLine("-------------------------------");
            foreach (var city in popcity)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }
        public void AddElementUsingOI()
        {
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"},
                new Student(){ Id = 5, Name="Manoj"}
            };

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + students.Count);

            Console.WriteLine("-------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine("Id : " + student.Id + ";" + " Name : " + student.Name);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }
        public void AddElementUsingCI()
        {
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + bigCities.Count);

            Console.WriteLine("-------------------------------");
            for (int i = 0; i < bigCities.Count; i++)
            {
                Console.Write(bigCities[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }
        public void ListAddString()
        {
            vstr.Add("aeio"); // adding elements using add() method
            vstr.Add("india");
            vstr.Add("Satsu");
            vstr.Add("Nosaka");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + vstr.Count);

            Console.WriteLine("-------------------------------");
            for (int i = 0; i < vstr.Count; i++)
            {
                Console.Write(vstr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }
        public void ListAddInt()
        {
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Count : " + primeNumbers.Count);

            Console.WriteLine("-------------------------------");
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.Write(primeNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }
    }
}
