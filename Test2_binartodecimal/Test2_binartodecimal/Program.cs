using System;

namespace Test2_binartodecimal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Napiš binární číslo co chceš převést na decimální číslo:         ");
            string sbinar = Console.ReadLine();
            try
            {
                int deci = Convert.ToInt32(sbinar, 2);
                Console.WriteLine($"Výsledek:   {deci}");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("!!!Neplatné číslo!!!");
                Console.ReadLine();
            }
        }
    }
}