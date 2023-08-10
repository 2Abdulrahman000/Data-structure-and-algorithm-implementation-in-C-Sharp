using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        static int[] array;
        static int[] temparray;
        static void Main(string[] args)
        {
            int[] arr = {30,20,40,5,90,80,10};
            Console.WriteLine("Before Sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            prepare(arr);
            Console.WriteLine("Before Sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        static void prepare(int [] arr)
        {
            array = arr;
            temparray=new int[arr.Length];
            divide(0,array.Length-1);
        }

        static void divide(int l, int h)
        {
            if (l < h)
            {
                int m = l + (h - l) / 2;
                divide(l, m);
                divide(m + 1, h);
                conquer(l, m, h);
            }
        }

        static void conquer(int l,int m,int h)
        {
            for (int i = l; i <= h; i++)
            {
                temparray[i] = array[i];
                int ii = l;
                int j = m + 1;
                int k = l;
                while (ii<m && j<h)
                {
                    if (temparray[ii] < array[j])
                    {
                        array[ii] = temparray[ii];
                        ii++;
                    }
                    else
                    {
                        array[ii] = temparray[j];
                        j++;
                    }
                    k++;
                }        
            }
        }

    }
}
