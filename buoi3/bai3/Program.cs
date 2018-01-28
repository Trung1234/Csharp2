using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("so fibonaci thu n la {0}",fibonaci(n));
        }
        
        static int fibonaci(int n){
           if ((n == 1) || (n == 2)) {
                     return 1;
            } else {
                int[] arr = new int[n];
                arr[0] = 1;
                arr[1] = 1;
               
                for (int i = 2; i < arr.Length; i++) {
                     arr[i] = arr[i - 1] + arr[i - 2];
                    
                }
                return arr[n-1];     
            }
        
        }
    }
}
