﻿using System;

namespace Question6_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
                    //            Multiply the numbers from K + 1 to N(think why this is correct). You
                    //may check the properties of the factorial function in Wikipedia:


            Console.WriteLine("Enter first number for factorial N ! ");
            int number1 = int.Parse(Console.ReadLine());

            int factorialN = 1;

            for (int i = 1; i <= number1 ; i++)
            {
                factorialN = factorialN * i;
            }

            Console.WriteLine(factorialN);

            Console.WriteLine("Enter first number for factorial K ! ");
            int number2 = int.Parse(Console.ReadLine());

            int factorialK = 1;

            for (int i = 1; i <= number2; i++)
            {
                factorialK = factorialK * i;
            }

            Console.WriteLine(factorialK);

            int value = factorialN / factorialK;

            Console.WriteLine(value);
        }

    }
}
