using System;

namespace ProgramOverloading
{
    public class Overloading
    {
        public class Data
        {
            public string nama;
            public double nomorTelepon;

            public void Print(string nama)
            {
                this.nama = nama;
                Console.WriteLine("Namanya adalah : {0}", this.nama);
            }
            public void Print(double nomorTelepon)
            {
                this.nomorTelepon = nomorTelepon;
                Console.WriteLine("Nomor HP : {0}", this.nomorTelepon);
            }
        }
    }
}