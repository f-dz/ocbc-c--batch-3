using System;

class Logika
{
    public static void Main()
    {
        for (int a = 10; a < 20; a = a = a + 1)
        {
            Console.WriteLine("Iterasi ke - " + a);
        }
    }
}