using System;
using System.Collections.Generic;

namespace CenaAIngredience
{
    public class Smoothe
    {
        public List<string> ingredience = new List<string>();
        public List<float> cena = new List<float>();
        public List<int> vybranaIngredience = new List<int>();
        float intcena = 0;
        
        public void StartUp()
        {
            ingredience.Add("Jahody");
            ingredience.Add("Banany");
            ingredience.Add("Mango");
            ingredience.Add("Jablko");
            
            cena.Add(1.5f);
            cena.Add(0.3f);
            cena.Add(2.5f);
            cena.Add(1.75f);
        }

        public void VyberIngredience()
        {
            foreach (var ingrediences in ingredience)
            {
                Console.Write($" - {ingrediences} - ");
            }
            Console.WriteLine();
            foreach (var cenas in cena)
            {
                Console.Write($" - {cenas} - ");
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Vyber ingredienci (1-4): ");
                vybranaIngredience.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Chcete pokračovat? (a/n)");
                string vyber = Console.ReadLine();
                if (vyber == "n")
                {
                    break;
                }
            }
        }

        public float Vyslednacena()
        {
            foreach (var ingredienceVybrana in vybranaIngredience)
            {
                switch (ingredienceVybrana)
                {
                    case 1:
                    {
                        intcena = intcena + 1.5f;
                        break;
                    }
                    case 2:
                    {
                        intcena = intcena + 0.3f;
                        break;
                    }
                    case 3:
                    {
                        intcena = intcena + 2.5f;
                        break;
                    }
                    case 4:
                    {
                        intcena = intcena + 1.75f;
                        break;
                    }
                }
            }
            return intcena * 1.5f;
        }
    }
}