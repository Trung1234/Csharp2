using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            b = a++;
            Console.WriteLine(b);
        }
    }
}
