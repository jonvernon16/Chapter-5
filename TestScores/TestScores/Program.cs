using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            int total = 0;
            int average;
            int i = -1;
            do
            {
                i++;
                Console.WriteLine("Enter Test Scores. 999 to exit. ");
                userEntry = Convert.ToInt32(Console.ReadLine());

                total = total + userEntry;
               

               
              

            } while (userEntry != 999);
            average = (total-999)  / i;
            Console.WriteLine("Total = " + (total - 999));
            Console.WriteLine("average = " + average);


        }
    }
}
