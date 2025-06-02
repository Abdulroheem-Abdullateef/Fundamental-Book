using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Enter number from 0 to 9, and see the word of the number: ");
          
            string word = Console.ReadLine();
            bool isNotNumber = int.TryParse(word, out int number);

            if (!isNotNumber)
            {
                Console.WriteLine("Invalid input, Enter numerical number from 0 to 9"); return;
            }

            string result = number switch
            {
                0 => $"{word} in word is Zero",
                1 => $"{word} in word is One",
                2 => $"{word} in word is Two",
                3 => $"{word} in word is Three",
                4 => $"{word} in word is Four",
                5 => $"{word} in word is Five",
                6 => $"{word} in word is Six",
                7 => $"{word} in word is Seven",
                8 => $"{word} in word is Eight",
                9 => $"{word} in word is Nine",
                _ => "Out of range, Enter numerical number from 0 to 9"
            };

            Console.WriteLine(result);

        }
    }
}
