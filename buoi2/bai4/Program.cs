using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "" ;
            Console.WriteLine("Enter a string!");

            string str = Console.ReadLine();
            int n = str.Length;
            for(int i=0;i<n;i++){
                c =  c + str[n-i-1];
                

            }
            if(c==str){
                Console.WriteLine("giong nhau!");
            }
            else{
                Console.WriteLine("khac nhau!");
            }
            
        }
    }
}
