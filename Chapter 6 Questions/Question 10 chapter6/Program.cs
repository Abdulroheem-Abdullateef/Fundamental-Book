using System;
using System.Runtime.Intrinsics.X86;

namespace Question_10_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

                //   You should use two nested loops, similar to the problem "Printing a 
                //Triangle". The outer loop must run from 1 to N, and the inner – from the 
                //value of the outer loop to the value of the outer loop +N - 1.


            Console.WriteLine("Enter  a number for triangle");
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < i + number; j++)
                {
                    Console.Write(j + "  ");
                    
                }

                Console.WriteLine();

            }



            

        }
    }
}
