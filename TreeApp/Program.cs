using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TreeApp
{
     class Program
   {
      
       private static List<String> DirSearch(string sDir)
        {
        List<String> files = new List<String>();
        try
        {
            foreach (string f in Directory.GetDirectories(sDir))
            {
                files.Add("├── " +f);
            }
            foreach (string f in Directory.GetFiles(sDir))
            {
                files.Add("\t└──"+f);
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                files.AddRange(DirSearch(d));
            }
        }
        catch (System.Exception excpt)
        {
            Console.WriteLine(excpt.Message);
        }

        return files;
        }
       static void Main(string[] args)
       {
        //    string path = Directory.GetCurrentDirectory();
           Console.WriteLine("nhap vao duong dan thu muc");
           string path = Console.ReadLine();
           foreach(var item in DirSearch(path)){
               Console.WriteLine(item.ToString());
           }
       }
   }
}
