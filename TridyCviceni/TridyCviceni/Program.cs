using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace TridyCviceni
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("'Write' or 'Read'");
                string vyber = Console.ReadLine();
                switch (vyber)
                {
                    case "Write":
                    {
                        Console.WriteLine("Napiš počet kol:");
                        byte pocetkol = byte.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Napiš barvu:");
                        string barva = Console.ReadLine();
                        
                        Console.WriteLine("Napiš znacka:");
                        string znacka = Console.ReadLine();
                        
                        Console.WriteLine("Napiš SPZ:");
                        string spz = Console.ReadLine();
                        
                        Vozidlo.listVozidlo.Add(new Vozidlo(pocetkol, barva, znacka, spz));
                        
                        break;
                    }
                    case "Read":
                    {
                        Vozidlo.Read();
                        break;
                    } 
                    default:
                    {
                        Console.WriteLine("!Zadán špatný požadavek!");
                        break;
                    }
                }
            }
        }

        class Vozidlo
        {
            public byte pocetKol;
            public string barva;
            public string znacka;
            public string spz;
            
            public int frekvenceKlaksonu;

            public static List<Vozidlo> listVozidlo = new List<Vozidlo>();

            public Vozidlo(byte pocetKol, string barva, string znacka, string spz)
            {
                this.pocetKol = pocetKol;
                this.barva = barva;
                this.znacka = znacka;
                this.spz = spz;
                
            }
            public static void Read()
            {
                foreach (var vozidlo in listVozidlo)
                {
                    Console.WriteLine($"{vozidlo.pocetKol} - {vozidlo.barva} - {vozidlo.znacka} - {vozidlo.spz}");
                }
            }
            
            public void Zatroubit()
            {
                Console.Beep(frekvenceKlaksonu, 10000);
            }
        }
    }
}