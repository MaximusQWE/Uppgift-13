using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console .ReadLine());
            if (ålder < 16)

            {
                Console.WriteLine("du är för ung");
            }

            else if (ålder > 19)
            {
                Console.WriteLine("du är för gammal");
            }

            else
            {
                Console.WriteLine("du är i rätt ålder");
            }
        }
    }
}