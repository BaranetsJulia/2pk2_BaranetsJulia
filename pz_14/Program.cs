using System;
using System.IO;
using System.Linq;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 3
            string path = @"C:\Users\User\Desktop\12345.txt";
            string outputPath = @"C:\Users\User\Desktop\123456.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string str = reader.ReadToEnd();
            reader.Close();
            int[] ar = str.Split("\n").Select(i => int.Parse(i)).ToArray();
            Array.Sort(ar);
            FileStream oFile = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(oFile);

            foreach (var item in ar)
            {
                writer.WriteLine(item);
            }

            writer.Close();
        }
    }
}
