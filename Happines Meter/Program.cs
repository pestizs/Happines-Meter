using System;

namespace Happines_Meter
{
    class Program
    {
        static void Main(string[] args)
        {
            string happiness;
            Console.WriteLine("Please tell us how happy you are feeling 1 to 5.");
            happiness = Console.ReadLine();

            switch (happiness)
            {
                case "1":
                    Console.WriteLine("You are very sad.");
                    break;
                case "2":
                    Console.WriteLine("You are sad.");
                    break;
                case "3":
                    Console.WriteLine("You ok.");
                    break;
                case "4":
                    Console.WriteLine("You are happy.");
                    break;
                case "5":
                    Console.WriteLine("You are very happy.");
                    break;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
