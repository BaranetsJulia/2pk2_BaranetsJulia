using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = 0; i <= 80; i += 4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("####");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 4");
            for (int j = 0; j <= 100; j++)
            {
                if (j % 5 == 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Задание 5");
            for (int i = 1, j = 40; i - j != 39; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
            Console.ReadLine();
        }
    }
}
