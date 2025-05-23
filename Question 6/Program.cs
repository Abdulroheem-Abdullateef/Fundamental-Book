using System;
using System.ComponentModel;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots(if they exist). 
             //Quadratic equations may have 0, 1 or 2 real roots.

            Console.WriteLine(" Enter your co efficient a ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine(" Enter your co efficient b ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(" Enter your co efficient  c ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * (a * c));

            if (discriminant==0)
            {
                double x1 = -b/2*a;
                Console.WriteLine(x1);
            }

            else if (discriminant > 0)
            {
                double x1 = -b + Math.Sqrt((b * b) - (4 * (a * c))) / 2 * (a);
                double x2= -b - Math.Sqrt((b * b) - (4 * (a * c))) / 2 * (a);

                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }

            else 
            {
                Console.WriteLine(" The Quadratic eqaution is not real ");
            }

        }
    }
}
