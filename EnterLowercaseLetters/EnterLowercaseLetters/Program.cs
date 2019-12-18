using System;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            string lowercase;
            bool again = true;
            string errEntry;

            Console.WriteLine("Please enter a lowercase letter. ");
            userEntry = Console.ReadLine();

            lowercase = userEntry.ToLower();
            
            while (userEntry != lowercase && again)
            {
                Console.WriteLine("error type !");
                errEntry = Console.ReadLine();

                if (errEntry == "!")
                {
                    again = false;
                }
            }
            
            
            Console.WriteLine("OK");
        }
    }
}
