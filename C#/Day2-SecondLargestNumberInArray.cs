using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public static class Day2
    {
        public static void FindSecondLargestNumberInArray(int[] arr)
        {
            int largestNum = arr[0];
            int secondLargestNum = int.MinValue;

            for (int i = 2; i < arr.Length; i++) {
                if (arr[i] > secondLargestNum && arr[i] < largestNum) {
                    secondLargestNum = arr[i];
                } 
                else if(arr[i] > largestNum)
                {
                    secondLargestNum = largestNum;
                    largestNum = arr[i];
                }
            }
            Console.WriteLine($"The second largest number is {secondLargestNum}");
        }
    }
}
