using System;

namespace pz_18
{
    class Program
    {
        //Вариант 3
        //Задание 1
        static double Arifm(int n, double a, double d)
        {
            if (n < 1) return 0;
            else if (n == 1) return a;
            return Arifm(n - 1, a, d) + d;
        }
        static void Main(string[] args)
        {
            double d = -1;
            double a = -8;
            int n = Convert.ToInt32(Console.ReadLine());
            double x = Arifm(n, a, d);
            Console.WriteLine(x);
        }
    }
}
