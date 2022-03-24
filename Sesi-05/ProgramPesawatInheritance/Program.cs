using System;

namespace ProgramPesawatInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            Pesawat.PesawatTempur pswttempur = new Pesawat.PesawatTempur();

            pesawat.nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 penumpang";

            pswttempur.nama = "AZ500TPU";
            pswttempur.JumlahRoda = 5;
            pswttempur.Ketinggian = "200 kaki";
            pswttempur.JumlahPenumpang = "2 Penumpang plus Kopilot dan Assistance";

            pesawat.Terbang();
            pswttempur.TerbangTinggi();
            Console.Read();

        }
    }
}
