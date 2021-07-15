using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Interact()
        {
            Console.WriteLine("Is there an echo in here?");
            String response = Console.ReadLine();
            Console.WriteLine(response);
            WaitForEnter();
        }

        private static void WaitForEnter()
        {
            Console.WriteLine("Press enter when ready... ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Interact();
        }

    }
}
