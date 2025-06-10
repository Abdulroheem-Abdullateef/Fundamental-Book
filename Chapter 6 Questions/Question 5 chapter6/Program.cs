using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Question_5_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {


                //  Fibonacci numbers start from 0 and 1, each additional is obtained as
                //the sum of the previous two.You can find the first n Fibonacci
                //numbers with a for-loop from 1 to n, and at each iteration calculate the
                //next number by using the previous two(which you will keep in two
                //additional variables).
                //6.Multiply the number



           double value1 = 0;
            double value2 = 1;
            


            Console.WriteLine("r1");

            Console.WriteLine("r2"); 

            Console.WriteLine("Enter your number");
            double n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double value3 = value1 + value2;

                value1 = value2;
                value2 = value3;


                Console.WriteLine(value3);

            }


        }
    }
}
