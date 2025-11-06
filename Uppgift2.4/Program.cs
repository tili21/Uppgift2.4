using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön för anställd 1: ");
            int lön1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lön för anställd 2: ");
            int lön2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lön för anställd 3: ");
            int lön3 = int.Parse(Console.ReadLine());

            int medel = (lön1 + lön2 + lön3) / 3;

            Console.WriteLine($"Medellönen är {medel} kr.");

            Console.ReadKey();
        }
    }
}
