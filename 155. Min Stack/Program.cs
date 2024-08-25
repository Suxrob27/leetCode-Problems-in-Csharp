using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155.Min_Stack
{
    public class MinStack
    {
        Stack<(int val, int minVal)> stack;
        int minval = int.MaxValue;
        public MinStack()
        {
            stack = new Stack<(int val, int minVal)> ();
        }

        public void Push(int val)
        {
            if(minval > val)
            {
                minval = val;
            }
           stack.Push((val,minval));
           
        }

        public void Pop()
        {
            stack.Pop();  
            if(stack.Count > 0)
            {
                minval = stack.Peek().minVal;
            }
            else
            {
                minval = int.MinValue;  
            }
        }

        public int Top()
        {
            return stack.Peek().val;
        }

        public int GetMin()
        {
            return stack.Peek().minVal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
