using System;
using System.ComponentModel;

namespace Question_1_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

                    // Write a program that prints on the console the numbers from 1 to N. 
                    //The number N should be read from the standard input.

            Console.WriteLine("Enter your number ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
