using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.add(0); q.add(1); q.add(2); q.add(3);
            q.add(4);
            q.del();
            q.show();
        }
    }
    class Queue 
    {
      //const int size = 10;
         int[] arr = new int[10];
         int rear;
         int front;
         public Queue()
        {
            rear = 0;
            front = 0;
        }
        public void add(int n)
        {
            if (rear == arr.Length) Console.WriteLine("FULL");
            else arr[rear++] = n;
        }
        public void del()
        { 
        if(rear==front) Console.WriteLine("EMPTY");
        else Console.WriteLine("the number deleted is :"+arr[front++]);
        }
      public void show()//تعديل هام جدا
        {
            if (rear == front) Console.WriteLine("is empty");
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.Write(" " + arr[i] + " ");
                }
            }
        }
    }    
}
