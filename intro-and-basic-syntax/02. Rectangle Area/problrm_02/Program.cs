//CONFIRMED from <PPatev>
using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive and parse rectangles width and height
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // We calculate the area
            double rectangleArea = height * width;

            // Print the result to the console
            Console.WriteLine($"{rectangleArea :F2}");
        }
    }
}