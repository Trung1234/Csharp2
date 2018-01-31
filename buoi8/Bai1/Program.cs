using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Int number: ");
            int  a = Convert.ToInt32(Console.ReadLine());
            int  b = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine($"Sum of 2 int number a and b {Caculator.Add(a,b)}");

            Console.WriteLine("Enter 3 Double number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Sum of 3 Double number a and b {Caculator.Add(c ,d, e)}");
        }
    }
    class Caculator{
        public static int Add(int a,int b){
            return a + b;
        }
        public static double Add(double a,double b,double c){
            return a + b + c;
        }
    }
}
