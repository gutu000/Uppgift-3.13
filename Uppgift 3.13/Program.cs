using System;

namespace Uppgift_3._13
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får delta");
            }
            else if (ålder >= 15 && ålder <= 20)
            {
                Console.WriteLine("Du får inte delta");
            }
        }
    }
}