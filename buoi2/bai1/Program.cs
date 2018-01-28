using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Enter the string to reverse :");
            string name = Console.ReadLine();
 
            char[] cArray = name.ToCharArray();
            string nameReverse = String.Empty;
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                nameReverse += cArray[i];
            }
            Console.WriteLine(nameReverse);
            

        }
    }
}
