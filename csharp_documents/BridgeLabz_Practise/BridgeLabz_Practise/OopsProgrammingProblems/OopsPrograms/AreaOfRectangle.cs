using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgrammingProblems.OopsPrograms
{
    public class Rectangle
    {
        public double length;
        public double breadth;
        public void SetDim(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double GetArea()
        {
            return length * breadth;
        }
    }
    public class RectangleOps
    {
        public void ExecuteRectangle()
        {
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();

            Console.Write("Enter the length of the first rectangle: ");
            double length1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of the first rectangle: ");
            double breadth1 = double.Parse(Console.ReadLine());

            rectangle1.SetDim(length1, breadth1);

            Console.Write("Enter the length of the second rectangle: ");
            double length2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of the second rectangle: ");
            double breadth2 = double.Parse(Console.ReadLine());

            rectangle2.SetDim(length2, breadth2);

            double area1 = rectangle1.GetArea();
            double area2 = rectangle2.GetArea();

            if (area1 > area2)
            {
                Console.WriteLine("The first rectangle has a higher area.");
            }
            else if (area2 > area1)
            {
                Console.WriteLine("The second rectangle has a higher area.");
            }
            else
            {
                Console.WriteLine("Both rectangles have the same area.");
            }
        }
    }
    public class AreaOfRectangle
    {
        public static void GetAreaRectangele()
        {
            RectangleOps or = new RectangleOps();
            or.ExecuteRectangle();
        }
    }
}
