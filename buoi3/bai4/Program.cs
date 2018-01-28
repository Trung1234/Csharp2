using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  bsnn=0, max, step;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a==b){
                Console.WriteLine("BSCNN la {0}",a);
            }
            else{
                if(a>b){
                    max = step = a;
                }
                else{
                    max = step = b;
                }
                while(true){
                    if(max%a==0&&max%b==0){
                        bsnn = max;
                        break;
                    }
                    max = max + step;
                }
                Console.WriteLine("BSCNN la {0}",bsnn);
            }
           
        }
    }
}
