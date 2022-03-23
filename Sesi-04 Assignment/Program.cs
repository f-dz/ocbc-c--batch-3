using System;

namespace Sesi_04_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("1. Segitiga Alfabet");
                Console.WriteLine("2. Segitiga Angka");
                Console.WriteLine("3. Faktorial");
                Console.WriteLine("4. Balik Angka");
                Console.WriteLine("5. Balik Huruf");
                Console.WriteLine("6. Converter Angka");
                Console.WriteLine("7. Tentang Saya");
                Console.WriteLine("8. Keluar");
                Console.WriteLine();
                Console.Write("Pilih menu : ");

                string input = Console.ReadLine();
                switch(input)
                {
                    case "1" : {
                        Console.WriteLine("\nMenu Segitiga Alfabet");
                        SegitigaAlfabet.Program();
                        MenuBack();
                        break;
                    }
                    case "2" : {
                        Console.WriteLine("\nMenu Segitiga Angka");
                        SegitigaAngka.Program();
                        MenuBack();
                        break;
                    }
                    case "3" : {
                        Console.WriteLine("\nMenu Faktorial");
                        Faktorial.Program();
                        MenuBack();
                        break;
                    }
                    case "4" : {
                        Console.WriteLine("\nMenu Balik Angka");
                        BalikAngka.Program();
                        MenuBack();
                        break;
                    }
                    case "5" : {
                        Console.WriteLine("\nMenu Balik Huruf");
                        BalikHuruf.Program();
                        MenuBack();
                        break;
                    }
                    case "6" : {
                        Console.WriteLine("\nMenu Converter Angka");
                        ConverterAngka.Program();
                        MenuBack();
                        break;
                    }
                    case "7" : {
                        Console.WriteLine("\nMenu Tentang Saya");
                        TentangSaya.Program();
                        MenuBack();
                        break;
                    }
                    case "8" : {
                        Environment.Exit(0);
                        break;
                    }
                    default : break;
                }
            }
        }

        static void MenuBack(){
            Console.Write("\nKembali ke menu utama..");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
