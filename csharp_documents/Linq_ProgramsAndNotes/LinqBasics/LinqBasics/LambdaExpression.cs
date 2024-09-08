using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public delegate bool IsTeenagerOrNot(StudentRecord record);
    public class StudentRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class AnonymousMethod_to_check_student_teenager_or__not
    {
        public static void CheckTeenager()
        {
            //Anonymous Method
            IsTeenagerOrNot isteenornot = delegate (StudentRecord sr) { return sr.Age > 12 && 
                                                                               sr.Age < 20 ;};
            Console.WriteLine("Enter the age to check teenager or not");
            int personage = int.Parse(Console.ReadLine());


            StudentRecord record = new StudentRecord(){ Age = personage};
            if (isteenornot(record))
            {
                Console.WriteLine("He/She age is "+ record.Age+" and is teenager");
            }
            else
            {
                Console.WriteLine("He/She age is "+ record.Age + " and is not teenager");
            }
        }
    }
    public class LambdaExpression
    {
        public static void GetResultTeenager()
        {
            AnonymousMethod_to_check_student_teenager_or__not.CheckTeenager();
        }
    }
}
