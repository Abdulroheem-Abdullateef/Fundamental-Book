using System;
using System.Runtime.Intrinsics.X86;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {


                    //            8.Write a program that, depending on the user’s choice, inputs int, double
                    //or string variable. If the variable is int or double, the program
                    //increases it by 1.If the variable is a string, the program appends "*" at
                    //the end.Print the result at the console. Use switch statement.



            Console.WriteLine(" Enter 0=int, 1=double, 2=string,");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 0 :
                    
                    Console.WriteLine("Enter int type");
                    int type = int.Parse(Console.ReadLine());
                    int o = 1;
                    Console.WriteLine($" your int is {type + o} ");
                    break;

                case 1:

                    Console.WriteLine("int variable +1 = int type");
                    double type2  = int.Parse(Console.ReadLine());
                    double d =1;
                    Console.WriteLine($"your double is {type2 + d} ");
                    break;

                case 2 :

                    Console.WriteLine("Enter string type");
                    string type3 = Console.ReadLine();
                    string star = "*";
                    Console.WriteLine($" your string is {type3 + star} ");
                    break;
                default:
                    Console.WriteLine("Invalid input ");
                    

                    break;
            }
        }
    }
}
