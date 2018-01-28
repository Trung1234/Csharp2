using System;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int usln=0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i=1;i<=a||a<=b;i++){
                if(a%i==0&&b%i==0){
                    usln = i;
                }
            }
            Console.WriteLine("USCLN la {0}",usln);
        }
    }
}
