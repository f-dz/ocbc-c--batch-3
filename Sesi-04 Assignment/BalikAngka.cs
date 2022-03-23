using System;

namespace Sesi_04_Assignment
{
    class BalikAngka
    {
        public static void Program()
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();
            int num = -1;

            if(int.TryParse(input, out num) && !input.Contains("-"))
            {
                for (int i = inputChar.Length; i > 0; i--)
                {
                    Console.Write(inputChar[i-1]);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}