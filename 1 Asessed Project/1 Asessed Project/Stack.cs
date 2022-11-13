using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Asessed_Project
{
    class Stack
    {
        private const int maxsize = 10;
        private int top = 0;
        private string[] array = new string[maxsize];

        public void Push(string value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                array[top++] = value;
                Console.WriteLine(value + "You've added a value");
            }
        }

        public string Pop(string value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return "";
            }
            else
            {
                return array[--top];
            }    
            
        }

        public string Peek()
        {
            return array[top - 1];
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxsize;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }

    }

}
