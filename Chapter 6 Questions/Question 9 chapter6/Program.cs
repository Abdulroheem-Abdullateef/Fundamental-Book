using System;
using System.ComponentModel;

namespace Question_9_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that for a given integers n and x, calculates the sum:
            // S = 1 + (1!/x) + 2!/(x^2) + ... n!/(x^n). 

            double sum = 1;
            double temp = 1;
            double factorial = 1;

            Console.WriteLine("Enter your number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int number2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number1; i++)
            { 
                    temp *= number2;
                    factorial *= i;
                    sum += temp / factorial;
            }

            Console.WriteLine($"The sum of the number is {sum} ");
        }
    }
}
