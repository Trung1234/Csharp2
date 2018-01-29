using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap vao so a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap vao so b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Phep cong 2 so:  {Caculator.Add(a,b)}");
            Console.WriteLine($"Phep tru 2 so:  {Caculator.Substract(a,b)}");
            Console.WriteLine($"Phep nhan 2 so: {Caculator.Multiply(a,b)}");
            Console.WriteLine($"Phep chia 2 so : {Caculator.Divide(a,b)}");
        }
    }
    class Caculator{
        public static int Add(int a,int b){
            return a+b;
        }
        public static int Multiply(int a,int b){
            return a*b;
        }
        public static int Substract(int a,int b){
            return a - b;
        }
        public static double Divide(double a,double b){
            return a/b;
        }
    }
}
