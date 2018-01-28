using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ta co chuoi fibonaci la");
            fibonaci(n);
        }
        static void fibonaci(int n){
           
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;
            Console.Write("{0} {1} ",arr[0],arr[1]);
            for (int i = 2; i < arr.Length; i++) {
                arr[i] = arr[i - 1] + arr[i - 2];
                Console.Write("{0} ",arr[i]);
            }
        }
    }
}
