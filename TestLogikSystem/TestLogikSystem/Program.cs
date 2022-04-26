using System;
using System.Diagnostics;
using System.Security.Policy;

namespace TestLogikSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Making new user");

            Console.WriteLine("Napište prvotní user name:");
            string vstupNewUserName = Console.ReadLine();
            Console.WriteLine("Napiš prvotní heslo:");
            string vstupNewHeslo = Console.ReadLine();
            Console.WriteLine("Napiš prvotní zůstatek:");
            string vstupNewZustatek = Console.ReadLine();
            
            Console.Clear();
            
            var User1 = new User();
            User1.username = vstupNewUserName;
            User1.password = vstupNewHeslo;
            User1.zustatek = vstupNewZustatek;

            while (User1.cykl == true)
            {
                Console.WriteLine("Napište user name:");
                string vstupUserName = Console.ReadLine();
                Console.WriteLine("Napište heslo:");
                string vstupHeslo = Console.ReadLine();
                    
                User1.Login(vstupUserName, vstupHeslo);
            }
            
            
        }
    }
}
