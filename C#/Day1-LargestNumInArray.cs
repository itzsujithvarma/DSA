using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public static class Day1
    {
        public static void FindLargestNumberInArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) { 
                if(arr[i] > max) max = arr[i];
            }
            Console.WriteLine($"The largest number is array is {max}");
        }
    }
}
