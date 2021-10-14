using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, s;
            s = j = 0;
            int[] a = new int[30];
            int[] b = new int[30];
            Random x = new Random();
            for (int i=0; i!=a.Length; i++)
            {
                a[i] = x.Next(-51, 51);
                Console.WriteLine(a[i]);
            }
            for (int i=0; i!=a.Length; i++)
            {
                if (a[i]>0)
                {
                    b[i] = a[i];
                    j++;
                }
            }
            s = 30 - j;
            Console.WriteLine("Количество отрицательных чисел: " + s);
        }
    }
}
