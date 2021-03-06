using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var dev1 = new DEV1();
            var dev2 = new DEV2();
            Console.WriteLine("Developers: {0} {1}", dev1.author, dev2.author);
        }
    }
}
