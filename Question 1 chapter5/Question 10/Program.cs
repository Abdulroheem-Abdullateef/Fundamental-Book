using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {

                    // 10.Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
                    //-If the score is between 1 and 3, the program multiplies it by 10.
                    //- If the score is between 4 and 6, the program multiplies it by 100.
                    //- If the score is between 7 and 9, the program multiplies it by 1000.
                    //- If the score is 0 or more than 9, the program prints an error message.





            Console.WriteLine("Enter number between 1 and 9");
            int input = int.Parse(Console.ReadLine());

            if (input > 1 && input <= 3)  Console.WriteLine($" your bonus point is {input*10}");
            

            if (input >= 4 && input <= 6) Console.WriteLine($" your bonus point is {input * 100}");
            

            if (input >= 7 && input <= 9)  Console.WriteLine($" your bonus point is {input * 1000}");
         

            else Console.WriteLine($" Error message");
             

            
            

            
        }
    }
}
