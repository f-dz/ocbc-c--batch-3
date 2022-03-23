using System;

namespace Sesi_04_Assignment
{
    class SegitigaAngka
    {
        public static void Program()
        {
            Console.Write("Masukkan range: ");
            string input = Console.ReadLine();
            int num = -1;
            
            if (int.TryParse(input, out num))
            {
                int range = int.Parse(input);
                int aEmpty = range;
                int number = 1;

                if (range < 0) Console.WriteLine("Wrong input!");
                else
                {
                    for (int i = 0; i < range; i++)
                    {
                        //Tampil Space
                        for (int j = 0; j < aEmpty-1 ; j++) Console.Write(" ");

                        //Tampil Angka
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(number);
                            number++;
                        }
                        number--;
                        for (int j = i; j > 0; j--)
                        {
                            number--;
                            Console.Write(number);
                        }

                        //Tampil Space
                        for (int j = aEmpty-1 ; j > 0; j--) Console.Write(" ");
                        
                        aEmpty--;
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
    
}