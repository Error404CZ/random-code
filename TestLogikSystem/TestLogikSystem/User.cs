using System;

namespace TestLogikSystem
{
    public class User
    {
        public string username;
        public string password;
        public string zustatek;

        public bool cykl = true;

        public void Login(string vstupUsername, string vstupPassworld)
        {
            Console.Clear();
            if (vstupUsername == username && vstupPassworld == password)
            {
                Console.WriteLine(zustatek);
                cykl = false;
            }
            else
            {
                Console.WriteLine("Špatné přihlašovací jméno nebo heslo");
            }
        }
        
    }
}