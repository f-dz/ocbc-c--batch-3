using System;

public class Project3 
{
    public static void Main(string[] args)
    {
        string nama;
        int umur;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK");
        Console.Write("Masukkan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukkan alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukkan umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama\t: {nama}");
        Console.WriteLine($"Alamat\t: {alamat}");
        Console.WriteLine($"Umur\t: {umur} tahun");
        Console.WriteLine("SUDAH DISIMPAN!");
        
    }
}