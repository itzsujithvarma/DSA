using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public static class Day3
    {
        public static void ReverseArrayWithoutAnotherArray(int[] arr)
        {
            int temp;

            for (int i = 0,j = arr.Length-1; i<j; i++,j--) { 
               temp = arr[i];
               arr[i] = arr[j];
               arr[j] = temp; 
            }
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
