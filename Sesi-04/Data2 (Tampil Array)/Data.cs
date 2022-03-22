using System;

class Data
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4]
        {
            "Motherboard", "Processor" , "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string item in contoh)
        {
            Console.WriteLine(item);
        }

        Console.Write("Press any key to continue...");
    }
}