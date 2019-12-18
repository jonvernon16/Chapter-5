using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;
            int total = 0;
            do
            {
                Console.Write("Please enter a number >>> ");
                entry = Convert.ToInt32(Console.ReadLine());

                total = total + entry;

                Console.WriteLine(total);

            } while (entry != 999);

           
        }
    }
}
