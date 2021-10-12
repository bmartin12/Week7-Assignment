using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();
            for (int i = userFirstName.Length - 1; i >= 0; i--)
            {
                Console.Write($"{userFirstName}"[i]);
            }
        }
    }
}
