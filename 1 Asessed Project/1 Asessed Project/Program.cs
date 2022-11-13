using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Asessed_Project
{
    internal class Program
    {
        static Queue queue = new Queue(10);
        static Queue tempQueue = new Queue(queue.size());

        static Stack<string> stack = new Stack<string>(10);
        static void Main(string[] args)
        {
            queue.Enqueue("James");
            queue.Enqueue("Bob");
            queue.Enqueue("Lilly");
            queue.Enqueue("Marc");
            queue.Enqueue("Joseph");
            queue.Enqueue("Alexander");
            queue.Enqueue("Marco");
            queue.Enqueue("Billy");
            queue.Enqueue("Terry");
            queue.Enqueue("Jake");

            Console.WriteLine("Enter the value of k: " + queue.size());
            string k = Console.ReadLine();
            int queueOne = queue.size();

            if (Convert.ToInt16(k)>queueOne)
            {
                Console.WriteLine("Value is too big");
            }
            for (int i = 0; i < Convert.ToInt32(k); i++)
            {
                stack.Push(queue.Dequeue());
            }
            int SIZE = queue.size();
            for(int i = 0; i < SIZE - Convert.ToInt16(k); i++)
            {
                tempQueue.Enqueue(queue.Dequeue());
            }


            for(int i = 0; i < Convert.ToInt32(k); i++)
            {
                queue.Enqueue(stack.Pop());
            }
            for (int i = 0; i < SIZE - Convert.ToInt16(k); i++)
            {
                queue.Enqueue(tempQueue.Dequeue());
            }
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }

            System.Console.ReadKey();
        }




    }

}