using System;

namespace Question_10_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
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
