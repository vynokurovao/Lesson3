using System;

namespace HW_classes_task2
{
    class Program
    {
        static void displayInformation(Figure figure)
        {
            Console.WriteLine(String.Format("The figure is {0}. It`s perimeter is {1}", figure.GetName(), figure.PerimeterCalculator()));
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
