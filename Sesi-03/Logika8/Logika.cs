using System;

class Logika
{
    public static void Main()
    {
        int i = 0;
        do
        {
            Console.WriteLine("i = {0}", i);
            i++;

            if (i > 5) break;
        } while (i < 10);
    }
}