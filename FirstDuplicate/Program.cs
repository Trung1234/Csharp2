using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 1, 1, 2, 2, 1};
            thu_nghiem(scores);
        }
        public static void thu_nghiem (int[] number) {            
            List<int> duplicate_num = new List<int>();
           List<int> duplicate_index = new List<int>();
           
           for (var i=0; i< number.Length; i++) {                
               int target = number[i];                
               for (var j = 0; j < number.Length; j++) {                    
                   if (number[j] == target && i < j) {
                       duplicate_num.Add(number[j]);
                       duplicate_index.Add(j);
                   }
               }            
            } 
            duplicate_index.Sort();           
            int smallest_index = duplicate_index[0];

            Console.WriteLine(number[smallest_index]);        
        }
    }
}
