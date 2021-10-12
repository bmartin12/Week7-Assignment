using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string usern;
            string pass;
            Console.WriteLine("sisesta kasutajatunnus");
            usern = Console.ReadLine();
            Console.WriteLine("sisesta parool");
            pass = Console.ReadLine();
            Console.WriteLine("sisesta pin kood");
            string pin = Console.ReadLine();

            int counter = 0;
            
            foreach (char character in pin)
            {
                counter++;
                if (pin.Length < 4)
                {
                    Console.WriteLine("vale pin proovi uuesti");
                    break;
                }

            }
            if ((usern == "admin") && (pass == "pass1234") && (pin == "1234"))
            {
                Console.WriteLine("tere tulemast");
            }
            else if ((usern != "admin") && (pass == "pass1234"))
            {
                Console.WriteLine("midagi läks valesti, proovi uuesti");
            }
            else if ((usern == "admin") && (pass != "pass1234"))
            {
                Console.WriteLine("midagi läks valesti, proovi uuesti");
            }
        }
    }
}
