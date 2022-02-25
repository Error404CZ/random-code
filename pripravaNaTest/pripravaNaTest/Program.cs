using System;

namespace pripravaNaTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int prvniCislo = 1;
            int druheCislo = 1;
            while (true)
            {
                prvniCislo = prvniCislo + druheCislo;
                Console.WriteLine(prvniCislo);
                druheCislo = prvniCislo;
            }
        }
    }
}