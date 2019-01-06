using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack
    {
        int top = -1;
        static int size = 10;
        public char[] stack = new char[size];
        
        public void Push(char chr)
        {
            if (!IsFull())
            {
                top++;
                stack[top] = chr;
            }
        }
        public char Pop()
        {
            if (!IsEmpty())
            {
                top--;
                return stack[top + 1];
            }
            else
                return '\0';
        }
        public char Peek()
        {
            if (!IsEmpty())
            {
                return stack[top];
            }
            else
                return '\0';
        }
        public bool IsFull()
        {
            if (top == size - 1)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
    }
}
