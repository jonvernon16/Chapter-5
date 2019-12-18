using System;

namespace TestingWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayForLoops();

        }
        public static void displayForLoops()
        {
            for (int i = 10; i >= 0; --i)
            {
                Console.WriteLine(i);
            }
        }
        public static void displayDoWhileLoop()
        {
            int count = 0;
            string response = null;
            

            do 
            {
                do
                {
                    Console.WriteLine(count);
                    count++;
                } while (count < 10);

                do
                {
                    Console.WriteLine(count);
                    count--;
                } while (count >= 0);

                Console.WriteLine("Would you like to count again? Y or N");
                response = Console.ReadLine();

            } while ("Y" != response);
            
        }
        public static void displayWhileLoops()
        {
            int num = 100;
            int num2 = 0;
            int num3 = 0;
            bool again = true;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            while (again)
            {
                num = num + 1;

            }
        }     
    }
}
