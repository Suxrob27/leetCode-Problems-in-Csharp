using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _876.Middle_of_the_Linked_List
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
        public ListNode MiddleNode(ListNode head)
        {

            ListNode once = head, twice = head;

            while (twice != null && twice.next != null)
            {
                once = once.next;
                twice = twice.next.next;
            }

            return once;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)  
                            }
                        }

                    }
                }
            };


          Solution solution = new Solution();
          solution.MiddleNode(l1);

        }
    }
}
