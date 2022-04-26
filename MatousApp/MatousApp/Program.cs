using System;
using System.Threading;

namespace MatousApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        bool repeat = true;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Welcome to World Wide Bank (WWB)");
                Console.WriteLine("Please select one of the options:");
                Console.WriteLine("{1}.New account");
                Console.WriteLine("{2}.Account balance");
                Console.WriteLine("{3}.Support");
                string userch = Console.ReadLine();
                switch (userch)
                {
                    case "1":
                        Console.WriteLine(" .Choose your account name:");
                        string nuaccount = Console.ReadLine();
                        Console.WriteLine(" .Choose your password:");
                        string nupassword = Console.ReadLine();
                        Console.WriteLine(" .What is your balance?:");
                        byte nubal = byte.Parse(Console.ReadLine());
                        Console.WriteLine(" .Thank you!");
                        var Account1 = new Account
                        {
                            account = nuaccount,
                            password = nupassword,
                            bal = nubal
                        };
                        Thread.Sleep(500);
                        break;
                    case "2":
                        Console.WriteLine("\n .Please type name of the account");
                        string inaccount = Console.ReadLine();
                        Console.WriteLine("\n .Write your password:");
                        string inpassword = Console.ReadLine();
                        Account1.Login(inaccount, inpassword);
                        break;
                    case "3":
                        Console.WriteLine("\n .there is no support >:]");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("\n .Please try again");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}