using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            double max = 0;
            int[,] A = new int[5, 5];
            Console.WriteLine("Вывод массива: ");
            Random rnd = new Random();
            for (i = 0; i<=4; i++)
            {
                for (j = 0; j<=4; j++)
                {
                    A[i, j] = rnd.Next(0, 100);
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
        }
    }
}
