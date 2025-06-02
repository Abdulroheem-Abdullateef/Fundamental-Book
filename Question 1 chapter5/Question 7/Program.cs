using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the greatest of given 5 numbers.
            int maximum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($" Enter your number at {i}:  ");
                int number = int.Parse(Console.ReadLine());
                if (number > maximum)
                {
                    maximum = number;
                }

            }

            Console.WriteLine($" The greatest number is {maximum}");
        }
    }
}
