using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TreeApp
{
     class Program
   {
      
        public static void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    Console.WriteLine("├── "+d);
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Console.WriteLine("\t└──"+f);
                    }
                    // DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
       static void Main(string[] args)
       {
           string path = Directory.GetCurrentDirectory();
        //    Console.WriteLine("nhap vao duong dan thu muc");
        //    string path = Console.ReadLine();
      
            DirSearch(path);
       }
   }
}

    // Cach 2

    //    private static List<string> DirSearch(string sDir)
    //     {
    //     List<string> files = new List<string>();
    //     try
    //     {
    //         foreach (string f in Directory.GetDirectories(sDir))
    //         {
    //             files.Add("├── " +f);
    //         }
    //         foreach (string f in Directory.GetFiles(sDir))
    //         {
    //             files.Add("\t└──"+f);
    //         }
    //         foreach (string d in Directory.GetDirectories(sDir))
    //         {
    //             files.AddRange(DirSearch(d));
    //         }
    //     }
    //     catch (System.Exception excpt)
    //     {
    //         Console.WriteLine(excpt.Message);
    //     }

    //     return files;
    //     }