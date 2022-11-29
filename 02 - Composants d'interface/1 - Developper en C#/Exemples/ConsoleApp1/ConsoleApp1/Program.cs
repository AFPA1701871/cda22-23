using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 1, b = 2;
            if (a == 1)
            {
                Console.WriteLine("toto" + "test");
                Personnes p = new Personnes(1);
                Console.WriteLine(p.Id);
                p.Id = 2; 
                Console.WriteLine(p.Id);
                
            }

        }
    }
}
