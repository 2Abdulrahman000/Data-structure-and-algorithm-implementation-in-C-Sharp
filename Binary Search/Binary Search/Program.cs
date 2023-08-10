using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;
            arr[3] = 3; 
            arr[4] = 4;
            arr[5] = 5;
            arr[6] = 6;
            arr[7] = 7;
            arr[8] = 8;
            arr[9] = 9;
            int key=9;
            Console.WriteLine(binarysearch(arr,key));
        }
        public static int binarysearch(int[] arr, int key)
        {
            int i = 0;
            int j = arr.Length - 1;
            int m = 0;
            while (true)
            {
                m = (i + j) / 2;
                if (key == arr[m]) return key;
                else if (i > j) return 2019;
                else if (key > arr[m]) i = m + 1;
                else if (key < arr[m]) j = m - 1;
            }
        }
    }
}

