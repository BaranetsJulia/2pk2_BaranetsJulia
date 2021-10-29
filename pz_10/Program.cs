using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Random rd = new Random();
            int[][] list = new int[7][];
            for (int i = 0; i < 7; i++)//Заполнение массива
            {
                list[i] = new int[rd.Next(5, 30)];
                for (int x = 0; x < list[i].Length; x++)
                {
                    list[i][x] = rd.Next(10, 100);
                }
            }
            //Задание 2
            Console.WriteLine("Массив:");//Вывод массива
            foreach (int[] i in list)
            {
                foreach (int x in i) Console.Write(x + "\t");
                Console.WriteLine();
            }
            //Задание 3
            int[] values = new int[7];
            for (int i = 0; i < 7; i++)
            {
                values[i] = list[i][list[i].Length - 1];
            }
            Console.WriteLine("Последние значения:");
            foreach (int i in values)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //Задание 4 и задание 5 не получилось
        }
    }
}
