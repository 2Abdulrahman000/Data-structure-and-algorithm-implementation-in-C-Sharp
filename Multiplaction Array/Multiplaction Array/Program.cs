using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplaction_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            Console.WriteLine("enter the row and colum");
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            int[,] a = new int[row, col];
            Console.WriteLine("enter the first matrix");//////////////////////////////matrix1
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] b = new int[row, col];
            Console.WriteLine("enter the secound matrix");////////////////////////matrix2
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] c = new int[row, col];
            Console.WriteLine("the mulipliction is:");/////////////////////////////////muliply
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] = 0;
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }////////////////////////////////////////multiply
        }
    }
}
