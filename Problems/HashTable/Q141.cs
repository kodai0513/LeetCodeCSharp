using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.HashTable
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    
    public class Q141
    {
        public bool HasCycle(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return false;
            }

            var fast = head;
            var slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if(slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}