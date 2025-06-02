using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write an if-statement that takes two integer variables and exchanges
             //their values if the first one is greater than the second one.


            Console.WriteLine("Enter your number1");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your number2");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2) Console.WriteLine($"{number1} is the greater number");
            if (number2 > number1) Console.WriteLine($"{number2} is the greater number");
            if (number2 == number1) Console.WriteLine("The two number are equal ");
            
        }
    }
}
