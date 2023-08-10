using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            s.push(0); s.push(1);
            s.push(2); s.push(3);
            s.show();
            s.pop();
            s.show();
        }
    }
    class stack
    {
        // const int size = 10;
        int[] arr = new int[10];
        int top;
        public stack()
        {
            top = -1;
        }
        public void push(int n)
        {
            if (top == arr.Length - 1) Console.WriteLine("FULL");
            else arr[++top] = n;
        }
        public void pop()
        {
            if (top == -1) Console.WriteLine("EMPTY");
            else top--;
        }
        public void show()
        {
            for (int i = top; i >= 0; i--)//تعديل مهم جدا////////
            {
                Console.WriteLine(" " + arr[i] + " ");
            }
            Console.WriteLine("___");
        }
    }
}
