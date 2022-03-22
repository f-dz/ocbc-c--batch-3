using System;

class String
{
    public static void Main()
    {
        string stringAwal = "C# membuat string mudah.";

        string substr = stringAwal.Substring(5, 12);

        Console.WriteLine("stringAwal: " + stringAwal);
        Console.WriteLine("substring: " + substr);
    }
}