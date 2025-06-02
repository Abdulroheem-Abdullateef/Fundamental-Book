using System;

namespace Question_2_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.The number N
                    //should be read from the standard input.



            Console.WriteLine("Enter number ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.WriteLine(i);
                }

                
            
            }

        }
    }
}
