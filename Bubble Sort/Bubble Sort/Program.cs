using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[6];
            arr[0] = 1;
            arr[1] = 5;
            arr[2] = 300;
            arr[3] = 4;
            arr[4] = 9;
            arr[5] = 30;
            for (int outer = 0; outer < arr.Length - 1; outer++)
            {
                for (int inner = 0; inner < arr.Length - 1 - outer; inner++)
                {
                    if (arr[inner ] > arr[inner+1])
                        swap(arr, inner, inner + 1);
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void swap(int[] arr, int m, int n)
        {
            int temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }
     }
}



