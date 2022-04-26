using System;

namespace MatousApp
{
    public class Account
    {
        public string account;
        public string password;
        public byte bal;


        public void Login(string inaccount, string inpassword)
        {
            Console.Clear();
            if (account == inaccount && password == inpassword)
            {
                Console.WriteLine(bal);

            }
            else
            {
                Console.WriteLine(" .Wrong account name or password");
            }
        }
    }
}