using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num :", secretNumber);
            
            // do ... while loop
            do
            {
                Console.WriteLine("Enter a number between 1 and 10");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed: {0}", secretNumber);
        }
    }
}