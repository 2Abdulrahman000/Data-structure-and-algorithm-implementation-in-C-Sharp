using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 35;
            arr[2] = 5;
            arr[3] = 7;
            arr[4] = 23;
            for (int outer= 1;outer < arr.Length; outer++)
            {
                for (int inner=outer-1;inner>=0;inner--)
                {
                    if (arr[inner] > arr[inner + 1]) 
                    {
                        swap(arr, inner, inner + 1);
                    }
                }     
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

         public  static void swap(int[] arr, int m, int n)
         {
            int temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }
        }
    }

