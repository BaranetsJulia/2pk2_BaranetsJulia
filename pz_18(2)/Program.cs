using System;

namespace pz_18_2_
{
    class Program
    {
        //Вариант 3
        //Задание 2
        static double Geometr(int n, double b, double q)
        {
            if (n == 1) return b;
            else return Geometr(n - 1, b, q) * q;
        }
        static void Main(string[] args)
        {
            double q = -0.5;
            double b = 3;
            int n = Convert.ToInt32(Console.ReadLine());
            double x = Geometr(n, b, q);
            Console.WriteLine(x);
        }
    }
}
