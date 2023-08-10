using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static void quicksort(int[] arr, int low, int high)
        {
            int i = low;
            int j = high;
            int mid=low+(high-low)/2;
            int pivot = arr[mid];
            while(i<=j)
            {
                while(arr[i]<pivot)
                {
                    i++;
                }

                while (arr[j]>pivot)
                {
                    j--;
                }
                if (i <= j) 
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
            {
                quicksort(arr, low, j);
            }

            if (high > i)
            {
                quicksort(arr, i, high);
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 30, 5, 40, 20, 90, 2341, 10 };
            Console.WriteLine("Before Quick Sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            ///////////////////////////////////////////////////
            Console.WriteLine();
            quicksort(arr, 0, arr.Length - 1);
            /////////////////////////////////////////////////////////

            Console.WriteLine("After Quick Sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine();
        }
    }
}
