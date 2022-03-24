using System;

namespace ProgramBilangan
{
    class Program
    {
        public int bilangan1, bilangan2;

        public void bilangan(int angka1, int angka2)
        {
            bilangan1 = angka1;
            bilangan2 = angka2;
        }

        public virtual void HitungBilangan()
        {
            Console.WriteLine("Overloading 1...--->>>");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}",
                bilangan1, bilangan2, bilangan1+bilangan2);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}",
                bilangan1, bilangan2, bilangan1*bilangan2);
        }

    }

    class Overide:Program
    {
        public override void HitungBilangan()
        {
            Console.WriteLine("Overloading 2...--->>>");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}",
                bilangan1, bilangan2, bilangan1/bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}",
                bilangan1, bilangan2, bilangan1-bilangan2);
        }
        static void Main(string[] args)
        {
            Program overiding = new Program();
            overiding.bilangan(10, 5);
            overiding.HitungBilangan();
            overiding = new Overide();
            overiding.bilangan(20, 5);
            overiding.HitungBilangan();
            Console.Read();
        }
    }
}
