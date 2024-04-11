using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode_Problems
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode firstNode = null;
            ListNode currentNode = null;

            while (l1 != null || l2 != null || carry != 0)
            {
                var l1Data = l1 != null ? l1.val : 0;
                var l2Data = l2 != null ? l2.val : 0;

                var sum = l1Data + l2Data + carry;

                int reminder;
                var quotient = Math.DivRem(sum, 10, out reminder);
                carry = quotient;   
                var newNode = new ListNode(reminder);
                if (firstNode == null)
                {
                    firstNode = newNode;
                    currentNode = newNode;
                }
                else
                { 
                  currentNode.next = newNode;   
                  currentNode = currentNode.next;   
                }

                l1 = l1?.next;
                l2 = l2?.next;  
            }
            while (firstNode != null)
            {
                Console.WriteLine(firstNode.val);
                firstNode = firstNode.next; 
            }
            return firstNode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3
                }
            };

            ListNode l2 = new ListNode()
                {
                val = 4,
                next = new ListNode()
                {
                    val = 5
                }
            };   

            Solution sl = new Solution();
            sl.AddTwoNumbers(l1, l2);
        }

    }
}
