using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _234.Palindrome_Linked_List
{
    
  public class ListNode
   {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
       {
           this.val = val;
           this.next = next;
             }
  }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            bool isPali = true;
            Stack reverseCount = new Stack();   
            Queue straightCount = new Queue();

            while (head != null)
            {
                reverseCount.Push(head.val);
                straightCount.Enqueue(head.next);
                head = head.next;   
            }

            if (reverseCount.Peek().Equals(straightCount.Peek()))
            {
                reverseCount.Peek();
                straightCount.Dequeue();
            }
            else
            {
                return false;
            }
            return isPali;
           
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                            next = new ListNode(5)
                    }
                }
            };
            Solution sl = new Solution();   
            sl.IsPalindrome(l1);    
        }
    }
}
