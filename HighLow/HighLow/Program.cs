using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(1, 100);
            int userEntry;
            bool again = true;
            int guesses = 6;
            while (again)
            {
                Console.WriteLine("Enter a number between 1 - 100. You'll have 6 guesses.");
                userEntry = Convert.ToInt32(Console.ReadLine());

                if (userEntry > r)
                {
                    Console.WriteLine("That number is too high");
                    guesses--;
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("That number is too low");
                    guesses--;
                }
                else if (userEntry == r)
                {
                    Console.WriteLine("That number is right!");
                    again = false;
                }
                if (guesses == 0)
                {
                    Console.WriteLine("You are bad at this game.");
                    again = false;
                }
                Console.WriteLine("You have " + guesses + " guesses left");
            }

        }
    }
}
