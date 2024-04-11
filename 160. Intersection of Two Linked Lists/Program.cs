

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160.Intersection_of_Two_Linked_Lists
{
    
    
    public class ListNode
   {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var lengthA = GetListNodeLength(headA);
            var lengthB = GetListNodeLength(headB);

           while(lengthA > lengthB)
            {
                headA = headA.next;
                lengthA--;
            }
           while(lengthB > lengthA)
            {
                headB = headB.next;
                lengthB--;
            }

           while(headA.val != headB.val)
            {
                headA = headA.next; 
                headB = headB.next; 
            }
            Console.WriteLine(headA.val);
            return headA;    
        }

        private static int GetListNodeLength(ListNode node)
        {
            var length = 0;
            while (node != null)
            {
                node = node.next;
                length++;
            }

            return length;  

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(4)
                        }
             }
           }
          };     
          ListNode l2 = new ListNode(1)
          { 
           next = new ListNode(4)
           {
               next = new ListNode(4)
               {

               }
           }
          };


          Solution sl = new Solution(); 
            sl.GetIntersectionNode(l1, l2);
          
        }
    }
}
