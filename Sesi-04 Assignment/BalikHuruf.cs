using System;
using System.Text.RegularExpressions;

namespace Sesi_04_Assignment
{
    class BalikHuruf
    {
        public static void Program()
        {
            Console.Write("Enter a Word: ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                char[] inputChar = input.ToCharArray();

                for (int i = inputChar.Length; i > 0; i--)
                {
                    Console.Write(inputChar[i-1]);
                }
            }
            else Console.WriteLine("Wrong input!");
        }
    }
}