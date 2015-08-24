using System;

namespace HW_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the sides of rectangle");
            double side1, side2;
            side1 = Convert.ToDouble(Console.ReadLine());
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine(String.Format("The area of rectangle is {0}", rectangle.Area));
            Console.WriteLine(String.Format("The perimeter of rectangle is {0}", rectangle.Perimeter));
            Console.ReadKey();
        }
    }
}
