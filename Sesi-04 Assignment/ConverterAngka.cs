using System;

namespace Sesi_04_Assignment
{
    class ConverterAngka
    {
        public static void Program()
        {
            string[] numberString = {"one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine"};
            int num = -1;

            Console.Write("Enter any Number: ");
            string input = Console.ReadLine();

            if(int.TryParse(input, out num) && !input.Contains("-") && !input.Contains("0"))
            {
                foreach (char item in input)
                {
                    int i = (int)Char.GetNumericValue(item);
                    if (i > 0) Console.Write(numberString[i-1] + " ");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}