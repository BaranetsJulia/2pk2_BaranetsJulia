using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\input.txt";
            string[] str = File.ReadAllLines(path);
            File.WriteAllText(path, "");//очищаем файл
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < str.Length; i++)
            {
                char[] ch = str[i].ToCharArray();
                Array.Sort(ch);//сортируем строку(массив символов) по алфавиту
                sw.WriteLine(ch);//записываем в файл отсортированную строку
            }
            sw.Close();
        }
    }
}
