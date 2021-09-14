using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinded sa said?");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (Number == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (Number == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (Number == 2)
            {
                Console.WriteLine("Rahuldav");

            }
            else
            {
                Console.WriteLine("Puudulik");
            }
        }
    }
}
