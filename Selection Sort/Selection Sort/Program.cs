using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 5;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 9;
            arr[5] = 30;

            int mini;
            for (int outer = 0; outer < arr.Length; outer++)
            {
                mini = outer;
                for (int inner = outer + 1; inner < arr.Length; inner++)
                {
                    if (arr[inner] < arr[mini])
                    {
                        mini = inner;
                    }
                }
                swap(arr, outer, mini);
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
