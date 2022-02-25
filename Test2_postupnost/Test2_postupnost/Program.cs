
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test2_postupnost
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            bool radic = true;
            double prvniCislo = 1;
            double druheCislo = 0;
            double finalCislo = 0;

            var finalCisloList = new List<double>();
            var finalCisloList2 = new List<double>();
            

            while (finalCislo < 4000000)
            {
                if(radic==true)
                {
                    finalCislo = prvniCislo + druheCislo;
                    prvniCislo = finalCislo;
                    Console.WriteLine($"1   {finalCislo}");
                    finalCisloList.Add(finalCislo);
                    radic = false;
                }else {
                    finalCislo = druheCislo + prvniCislo;
                    druheCislo = finalCislo;
                    Console.WriteLine($"2   {finalCislo}");
                    finalCisloList.Add(finalCislo);
                    radic = true;
                }
            }

            foreach (var finalCisloListDouble in finalCisloList)
            {
                if (finalCisloListDouble % 2 == 0)
                {
                    finalCisloList2.Add(finalCisloListDouble);
                }
            }
            
            Console.WriteLine();
            Console.WriteLine(finalCisloList2.Sum());
            
            
            
            Console.ReadLine();
        }
    }
}