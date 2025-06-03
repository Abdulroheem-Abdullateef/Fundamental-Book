using System;

namespace Question_3_charpter6
{
    class Program
    {
        static void Main(string[] args)
        {

                       //3.Write a program that reads from the console a series of integers and
                         //prints the smallest and largest of them.

            int lowest = 0;
            int largest = 0;
            bool firstNumber = true;    


            Console.WriteLine("Enter a lenght numbers to know your largest and lowest");
            int number = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter a number");
                int number2 = int.Parse(Console.ReadLine());

                if (firstNumber)
                {
                    largest = number2;
                    lowest = number2;
                    firstNumber = false;
                }
                else
                {

                    if (number2 > largest)
                    {
                        largest = number2;
                    }

                    if (number2 < largest)
                    {
                        lowest = number2;
                    }

                }


            }
            Console.WriteLine($" The largest is {largest} and the lowest is {lowest}");
        }
    }
}
