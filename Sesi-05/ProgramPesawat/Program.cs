using System;

namespace ProgramPesawat
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat.class_pesawat pesawat = new Pesawat.class_pesawat();
            pesawat.nama = "GARUDAKU";
            pesawat.Ketinggian = "2500 kaki";

            pesawat.Terbang();
            pesawat.SudahTerbang();
            Console.Read();
        }
    }
}
