using System;

public class Project4 
{
    public static void Main(string[] args)
    {
        string username;
        string password;
        int age;
        string gender;
        bool status = false;
        int nilai1;
        int nilai2;
        int nilai3;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK");
        
        //INPUT NAMA
        Console.Write("Masukkan username: ");
        username = Console.ReadLine();

        //INPUT PASSWORD
        Console.Write("Masukkan password: ");
        password = Console.ReadLine();

        //INPUT UMUR
        Console.Write("Masukkan umur: ");
        age = int.Parse(Console.ReadLine());       
        while(true) {
            Console.Write("Masukkan gender (Laki-Laki/Perempuan): ");
            gender = Console.ReadLine();
            if (gender == "Laki-Laki" || gender == "Perempuan") break;
            else Console.WriteLine("Masukkan Salah!");
        }

        //INPUT STATUS MENIKAH
        string getStatus;
        while(true) {
            Console.Write("Status menikah (Sudah/Belum): ");
            getStatus = Console.ReadLine();
            if (getStatus == "Belum" || getStatus == "Sudah") break;
            else Console.WriteLine("Masukkan Salah!");
        }
        if (getStatus == "Sudah") status = true;

        //INPUT NILAI 1 2 3
        Console.Write("Masukkan nilai 1: ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai 2: ");
        nilai2 = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai 3: ");
        nilai3 = int.Parse(Console.ReadLine());

        //HITUNG TOTAL DAN RATA-RATA
        int sum = nilai1+nilai2+nilai3;
        double rataNilai = sum/3.0;

        //CETAK OUTPUT
        Console.WriteLine();
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Umur\t\t: {age} tahun");
        Console.WriteLine($"Username\t: {username}");
        Console.WriteLine($"Jenis Kelamin\t: {gender}");
        Console.WriteLine($"Status Nikah\t: {status}");
        Console.WriteLine($"Total Nilai\t: {sum}");
        Console.WriteLine($"Rata Nilai\t: {Math.Round(rataNilai, 2)}");
        Console.WriteLine("SUDAH DISIMPAN!");
        
    }
}