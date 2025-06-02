using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {



            //3.Write a program that finds the biggest of three integers, using nested
            //if statements.
            
            
            Console.WriteLine("Enter your first number ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3 ) Console.WriteLine($"{number1} is the biggest between {number2} and {number3} ");

            if (number2 > number1 && number2 > number3 ) Console.WriteLine($"{number2} is the biggest between {number1} and {number3}");

            if (number1 == number2 && number2 == number3) Console.WriteLine("The three number are equal");

            else Console.WriteLine($"{number3} is the biggest between {number1} and {number2}");



        }
    }
}
