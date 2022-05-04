using System;

namespace pz_2s_11 //Вариант 3
{
    class Test
    {
        public Test(int val) => this.val = val;
        public int val;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(12);
            unsafe
            {
                fixed (void* ptr = &test.val)
                {
                    char* ptr2 = (char*)ptr;
                    ptr2[0] = 'A';
                    ptr2[1] = 'B';
                    Console.WriteLine(ptr2[0]);
                    Console.WriteLine(ptr2[1]);
                }
                Console.WriteLine(test.val);
            }
        }
    }
}
