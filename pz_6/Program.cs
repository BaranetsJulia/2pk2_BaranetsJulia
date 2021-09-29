using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите число ");
            a = Convert.ToInt32(Console.ReadLine());
            b = 1;
            c = a % b;
            while (c == 0)
            {
                b++;
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                    break;
                }
            }
            
            
              
        }
    }
}
