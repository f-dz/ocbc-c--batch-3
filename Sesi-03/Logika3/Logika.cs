using System;

class Logika
{
    public static void Main()
    {
        string username;
        String password;

        Console.Write("Username: ");
        username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        if(username == "ocbc" && password == "bootcamp")
            Console.WriteLine("Anda berhasil login");
        else 
            Console.WriteLine("Username atau Password salah");
    }
}