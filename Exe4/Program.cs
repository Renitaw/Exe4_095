using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_StackUsingArray
{
    class Stack
    {
        int[] Renita = new int[114];
        private int top;
        private int max;
        public Stack(int size)
        {
            Renita = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Renita[++top] = item;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("Popped element is: " + Renita[top]);
                return Renita[top--];
            }
        }
    }
}
