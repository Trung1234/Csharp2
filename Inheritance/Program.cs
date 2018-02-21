using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==== Inheritance - Tính Kế Thừa ====
            // is-a relationship
            Samsung S8 = new Samsung();
            S8.Name = "Samsung Galaxy S8";
            // S8.OS = "Android";
            S8.Call();
            System.Console.WriteLine(S8.OS);
            IPhone iphone7 = new IPhone();
            iphone7.Siri();
            System.Console.WriteLine(iphone7.OS);
            // ==== Polymorphism - Tính Đa Hình ====
            S8.Text();
            iphone7.Text();
            // handle data
            Smartphone phone1 = new Samsung();
            phone1.Call();
            Smartphone phone2 = new IPhone();
            phone2.Call();
            Smartphone[] dataArray = new Smartphone[] {phone1, phone2};
        }
    }
}
