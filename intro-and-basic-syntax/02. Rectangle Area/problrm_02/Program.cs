﻿using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = height * width;

            Console.WriteLine($"{area:F2}");
        }
    }
}