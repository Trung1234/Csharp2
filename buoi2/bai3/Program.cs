using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the edge");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                for(int j=0;j<=i;j++){
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
}
