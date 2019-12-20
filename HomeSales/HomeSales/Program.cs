using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            double sales;
            double dTotal = 0;
            double eTotal = 0;
            double fTotal = 0;
            double GrandTotal = 0;
            double largestSale;
           
            do
            {
                Console.Write("What are the initals of the sales person? (Type Z when done!) >>> ");
                userEntry = Console.ReadLine();

                if (userEntry == "D" || userEntry == "d")
                {
                    Console.WriteLine("What are the sales for Danielle?");
                    sales = Convert.ToDouble(Console.ReadLine());

                    dTotal = sales + dTotal;
                }
                else if (userEntry == "E" || userEntry == "e")
                {
                    Console.WriteLine("What are the sales for Edward?");
                    sales = Convert.ToDouble(Console.ReadLine());

                    eTotal = sales + eTotal;
                }
                else if (userEntry == "F" || userEntry == "f")
                {
                    Console.WriteLine("What are the sales for Francis?");
                    sales = Convert.ToDouble(Console.ReadLine());

                    fTotal = sales + fTotal;
                }
            } while (userEntry != "z");
            largestSale = Math.Max(dTotal, fTotal, eTotal);
            GrandTotal = dTotal + eTotal + fTotal;
            Console.WriteLine("The totals are below : ");
            Console.WriteLine("Danelle " + dTotal);
            Console.WriteLine("Edward " + eTotal);
            Console.WriteLine("Francis " + fTotal);
            Console.WriteLine("Grand Total " + GrandTotal);
            Console.WriteLine("Largest sale " +  );
        }
    }
}
