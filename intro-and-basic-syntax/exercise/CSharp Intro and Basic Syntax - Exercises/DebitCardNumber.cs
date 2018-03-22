using System;

namespace CSharp_Intro_and_Basic_Syntax___Exercises
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum.ToString("D4")} {secondNum.ToString("D4")} {thirdNum.ToString("D4")} {fourthNum.ToString("D4")}");
        }
    }
}
