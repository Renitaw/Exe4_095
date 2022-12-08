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
        public bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }
        public void display()
        {
            if (empty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + Renita[i]);
                }
            }
        }
    }
    class program
    {
        static void Main()
        {
            Stack s = new Stack(114);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);

                switch (ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                }
            }
        }
    }
}


