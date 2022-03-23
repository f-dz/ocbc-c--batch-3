using System;

namespace Sesi_04_Assignment
{
    class Faktorial
    {
        public static void Program()
        {
            Console.Write("Enter any Number: ");
            string input = Console.ReadLine();
            int result = 1;
            int num = -1;

            if (int.TryParse(input, out num))
            {
                int number = int.Parse(input);

                if (number < 0) Console.WriteLine("Wrong input!");
                else
                {
                    for (int i = number; i >= 1; i--) result *= i;
                    Console.WriteLine("Factorial of {0} is: {1}", number, result);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}