using System;

namespace HelloWorld
{
    
    class Program
    {

        static void Main(string[] args){
            int n, i, j, binno = 0;
            
            Console.WriteLine("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
          
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nSo trong he nhi phan tuong duong   la {0} }.\n", binno);
    }
}
