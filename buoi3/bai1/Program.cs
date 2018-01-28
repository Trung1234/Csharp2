using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so n");
            int n = int.Parse(Console.ReadLine());
            if(isPrime(n)==true){
                Console.WriteLine("la so nguyen to");
            }
            else{
                Console.WriteLine("khong phai so nguyen to");
            }
            
            

        }
        static bool isPrime(int n){
            bool check =true;
            if(n<=1) check = false;
        
            for(int i=2;i<n;i++){
                if(n%i==0) check = false;
            }
            return check;
    
        }
    }
}
