using System;
namespace PR2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Целые числа от 100 до 200, кратные трем:");
            Console.WriteLine("========================================");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
