using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace CenaAIngredience
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Smoothe = new Smoothe();
            
            Smoothe.StartUp();
            Smoothe.VyberIngredience();
            Console.WriteLine($"Vase cena: {Smoothe.Vyslednacena()}");
        }
        
    }
}