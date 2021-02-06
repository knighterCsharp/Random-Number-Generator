using System;

namespace random_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic information
            int num2 = 0;
            Console.WriteLine("Welcome to the RandoMizer, Made by knighter, 2020\r");
            Console.WriteLine("--------------------------------------------------------------");

            //mechanism
            Console.WriteLine("Please choose a number between 1 and 2.1 billion (limitations)\r");
            num2 = Convert.ToInt32(Console.ReadLine());

            //randomizer code
            Random rnd = new Random();
            int RDresult = rnd.Next(1, num2);  // creates a number between 1 num2 value

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(RDresult);
            // end result
            Console.WriteLine("That number that appeared was randomly generated.\r");
            Console.WriteLine("Press the E key to close this app");
            Console.ReadKey();
        }
    }
}
