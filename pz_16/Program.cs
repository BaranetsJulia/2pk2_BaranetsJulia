using System;

namespace pz_16
{
    class Program
    {
        //Вариант 3
        static void GetLimetSumm(int n, out int a)
        {
            a = 0;
            for (int i = 0; i <= n; i++)
            {
                a += i;
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            GetLimetSumm(n, out sum);
        }
    }

}
