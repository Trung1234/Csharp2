using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("moi nhap vao chu co 8 ki tu ");
                string nhap = Console.ReadLine();
                if(nhap.Length != 8){
                    Console.WriteLine("Ban da nhap sai ");
                }else{
                    char[] array = nhap.ToCharArray();
                    char[] temp = {'*','*','*','*','*','*','*','*'};
                    while(true){
                        Console.Write("nhap vao ki tu: ");
                        char input = Convert.ToChar(Console.ReadLine());
                        for(int j=0; j< array.Length ;j++){
                            if(input == array[j]){
                                temp[j] = array[j];
                            }
                        }
                        Console.WriteLine("o chu luc nay la");
                        Console.WriteLine(temp);
                        string te = Convert.ToString(temp);
                        if(nhap == te){
                            Console.WriteLine("win ");
                            break;
                        }
                    }
                    
                }
                
                
            }
            catch (FormatException)
            {
                Console.WriteLine("ki tu  nhap khong hop le ");
            }
        }
    }
}
