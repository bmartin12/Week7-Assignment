using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mis on sinu eesnimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("mis on sinu perekonnanimi");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Tere {userFirstName[0]}. {userLastName[0]}.!");
        }
    }
}
