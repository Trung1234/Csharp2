using System;
using System.Collections.Generic;
using System.Linq;

namespace buoi5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai1();
            // Bai2();
            // Bai4();
            // Bai3();
            bai6();
        }
        static void Bai3(){
            try
            {
         
                List<int> listNumb = new List<int>();
                Console.Write("Nhap so phan tu cua List: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.Write("nhap phan tu thu {0}: ",i+1);
                    int input = Convert.ToInt32(Console.ReadLine());
                    listNumb.Add(input);
                }
                listNumb.Sort();
                Console.WriteLine("ban muon tim phan tu lon thu may: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" {0}",listNumb[a]);
                
                Console.Write("\n");
            }
            catch (FormatException e)
            {
               Console.WriteLine("Ban phai nhap mot so");
               Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e){
                Console.WriteLine(e.Message);
            }
        
        }
         static void Bai2(){
            try
            {
                string temp = null;
                List<string> listString = new List<string>();
                Console.Write("Nhap so phan tu cua List: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.Write("nhap phan tu thu {0}: ",i+1);
                    string input = Console.ReadLine();
                    listString.Add(input);
                }
                Console.WriteLine("Nhap vao ki tu dau tien");
                char first = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Nhap vao ki tu cuoi cung");
                char last = Convert.ToChar(Console.ReadLine());
            

                for(int i=0; i < listString.Count;i++){
                 
                    
                    if (first == listString[i][0] && last == listString[i][listString[i].Length-1])
                    {
                        temp = listString[i];
                        break;
                    } 
                }
                if(temp == null){
                    Console.WriteLine("Khong co");
                }
                else {
                    Console.WriteLine("ta co chuoi can tim");
                    Console.WriteLine(temp);    
                }

            }
            catch (Exception e )
            {
               Console.WriteLine(e.Message);
               Console.WriteLine("Ban phai nhap mot chuoi");
            }
        }
        static void Bai4(){
            try
            {
                List<string> listString = new List<string>();
                Console.Write("Nhap so phan tu cua List: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.Write("nhap phan tu thu {0}: ",i+1);
                    string input = Console.ReadLine();
                    listString.Add(input);
                }
                listString.Sort();
                Console.WriteLine("Mang moi theo thu tu alphabet la");
                for(int i=0;i<listString.Count;i++){
                    Console.Write(" {0}",listString[i]);
                    
                    Console.Write("\n");

                }
            }
            catch (Exception e )
            {
               Console.WriteLine(e.Message);
               Console.WriteLine("Ban phai nhap mot so");
            }
        }
        static void Bai1(){
            try
            {
                List<int> listNumb = new List<int>();
                Console.Write("Nhap so phan tu cua List: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.Write("nhap phan tu thu {0}: ",i+1);
                    int input = Convert.ToInt32(Console.ReadLine());
                    listNumb.Add(input);
                }
                Console.Write("Cac phan tu chan trong List la :");
                for(int i=0;i<n;i++){
                    if(listNumb[i] %2 ==0){
                        Console.Write(" {0}",listNumb[i]);
                    }
                    Console.Write("\n");

                }
            }
            catch (FormatException)
            {
            
               Console.WriteLine("Ban phai nhap mot so");
            }
        }
        static void bai6(){
            List<Student> studentlist = new List<Student>(){
               new Student(){Name = "ducanh" , Point=5},
               new Student(){Name= "vananh",Point=6},
               new Student(){Name = "tung" , Point=5},
               new Student(){Name= "huong",Point=7},
               new Student(){Name = "trung" , Point=5},
               new Student(){Name= "hieu",Point=8}
           };
         
          
            var result = from stu in studentlist
                     let average = studentlist.Sum(tol=>tol.Point)/studentlist.Count
                     where stu.Point < average
                     select stu;                  
            foreach (var item in result)
           
            {
                 System.Console.WriteLine(item.Name);
            }

        }
        public class Student
        {
            public string Name { get; set; }
            public int Point { get; set; }
        }
    }

}
