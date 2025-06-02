using System;
using System.ComponentModel;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {

                     // We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0.Examples:
                    //-If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0.
                   // If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.


            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter third number");
            int number3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter fourth number");
            int number4 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter fifth number");
            int number5 = int.Parse(Console.ReadLine());

            bool isSubset = false;


            if (number1 + number2 == 0)
            {
                Console.WriteLine($" {number1} , {number2}");
                isSubset = true;
            }
            
            
            if (number1 + number2 + number3 == 0)
            {
                Console.WriteLine($" {number1} , {number2} , {number3}");
                isSubset = true;
            }


            if (number1 + number2 + number3 + number4 == 0)
            {
                Console.WriteLine($" {number1} , {number2} , {number3} , {number4}");
                isSubset = true;
            }


            if (number1 + number2 + number3 + number4 + number5 == 0)
            {
                Console.WriteLine($" {number1} , {number2} , {number3} , {number4} , {number5}");
                isSubset = true;
            }

            if (number2 + number3  == 0)
            {
                Console.WriteLine($" {number2} , {number3}");
                isSubset = true;
            }

            if (number2 + number3 + number4 == 0)
            {
                Console.WriteLine($" {number2} , {number3} , {number4}");
                isSubset = true;
            }


            if (number2 + number3 + number4 +  number5 == 0)
            {
                Console.WriteLine($" {number2} , {number3} , {number4} , {number5}");
                isSubset = true;
            }

            if (number3 + number4 == 0)
            {
                Console.WriteLine($"{number3} , {number4}");
                isSubset = true;
            }

            if (number3 + number4 + number5 == 0)
            {
                Console.WriteLine($" {number3} , {number4} , {number5}");
                isSubset = true;
            }

            if (number4 + number5 == 0)
            {
                Console.WriteLine($" {number4} , {number5}");
                isSubset = true;

            }

            if(!isSubset) Console.WriteLine($" number is not in subset");
            


            



        }
    }
}
