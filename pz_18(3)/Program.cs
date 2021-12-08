using System;

namespace pz_18_3_
{
    class Program
    {
        //Вариант 3
        //Задание 3
        static void Bomber(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b) return;
            Bomber(b > a ? a + 1 : a - 1, b);
        }
        static void Main(string[] args)
        {
            Bomber(60, 0);
        }
    }
}
