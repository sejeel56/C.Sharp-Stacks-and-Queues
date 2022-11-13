using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Asessed_Project
{
    class Queue
    {
        private readonly int maxsize = 10;
        private string[] store;
        private int head = -1;
        private int tail = -1;
        private int numItems;

        public Queue()
        {
            store = new string[maxsize];
        }

        public Queue(int size)
        {
            maxsize = size;
            store = new string[maxsize];
        }

        public void Enqueue(string value) // adds items to the tail of queue
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
           if (head == -1) head = 0;
            tail = (tail + 1) % maxsize;
            store[tail] = value; 
        }

        public string Dequeue() // Decrease count of items in queue by 1
        {
            string value;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return "";
            }
           value = store[head];
            if(head == tail)
            {
                head = -1;
                tail = -1;
            }
            else
            {
                head = (head + 1) % maxsize;
            }
            return value;
        }

        public string Peek()
        {
            return Convert.ToString(head);
        }

        public bool IsEmpty() // checks/verifies if a stack is empty or not (True/False)
        {
            if (head == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsFull() // checks/verifies if a stack is full or not (True/False)
        {
            if (head == 0 && tail == maxsize - 1) 
            {
                return true; 
            }
            if (head == tail + 1)
            {
                return true;
            }
             return false;

        }
        public int size()
        {
            return maxsize; //returns the maxium size of the stored items (10)
        }
    }
}
