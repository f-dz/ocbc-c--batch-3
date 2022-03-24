using System;

namespace ProgramOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloading.Data datanew = new Overloading.Data();
            datanew.Print("Foxy");
            datanew.Print(62819999999);
        }
    }
}
