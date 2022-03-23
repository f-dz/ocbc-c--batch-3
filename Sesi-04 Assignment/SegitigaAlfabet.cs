using System;

namespace Sesi_04_Assignment
{
    public class SegitigaAlfabet
    {
        public static void Program()
        {
            int range = 5;
            int aEmpty = range;
            char abjad = 'A';
            
            for (int i = 0; i < range; i++)
            {
                //Tampil Space
                for (int j = 0; j < aEmpty-1 ; j++) Console.Write(" ");

                //Tampil Abjad
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(abjad);
                    abjad++;
                }
                abjad--;
                for (int j = i; j > 0; j--)
                {
                    abjad--;
                    Console.Write(abjad);
                }

                //Tampil Space
                for (int j = aEmpty-1 ; j > 0; j--) Console.Write(" ");
                
                aEmpty--;
                Console.WriteLine();
            }
        }
    }
    
}