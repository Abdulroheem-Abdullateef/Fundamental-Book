﻿using System;

namespace Question_8_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

                //  In combinatorics, the Catalan numbers are calculated by the following
                //formula:Cn = 1/n+1(2n/n)=(2n)!/(n+1)!n!, for n ≥ 0.Write a program that
                //calculates the nth Catalan number by given n.


           Console.WriteLine("calculate for factorial n ");
            Console.WriteLine("Enter factorial N: ");
            int n = int.Parse(Console.ReadLine());

            decimal factorial = 1;
            decimal factorialN = 1; 
             decimal factorialNplus1 =1;
            
            for (int i =1;  i <= n; i++)
            {
                factorialN *= i;

            }
            Console.WriteLine($"The factorial of n is {factorialN}");

            Console.WriteLine("calculate for factorial 2n  ");
            double q = 2 * n;
            for (int i = 1; i <= q ; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of 2n is {factorial}\n ");


            Console.WriteLine("calculate for factorial :  n + 1  ");
            double k = n + 1;

            for (int i = 1; i <= k ; i++)
            {
                factorialNplus1 *= i;
            }

            Console.WriteLine($"The factorial of : n + 1 is  {factorialNplus1}");


        }
    }
}
