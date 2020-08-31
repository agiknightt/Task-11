using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 98;

            for (int i = 7; i <= maxNumber; i += 7)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
