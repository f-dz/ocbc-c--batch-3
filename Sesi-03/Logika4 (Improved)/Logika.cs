using System;

class Logika
{
    public static void Main()
    {
        double nilai;
        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 85) Console.WriteLine("Kamu mendapat Grade A");
        else if (nilai >= 65) Console.WriteLine("Kamu mendapat Grade B");
        else if (nilai >= 45) Console.WriteLine("Kamu mendapat Grade C");
        else if (nilai >= 25) Console.WriteLine("Kamu mendapat Grade D");
        else if (nilai < 25)
        {
            Console.WriteLine("Kamu mendapat Grade E");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Saya akan mulai giat belajar {0}", i);
            }
        }


    }
}