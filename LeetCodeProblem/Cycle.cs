using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Cycle
    {
        public static bool HasCycle(ListNode head)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int res = -1;
            int c = 0;
            while (head != null)
            {
                if (!d.ContainsKey(head.val))
                {
                    d.Add(head.val, c);
                }
                else
                {
                    res = d[head.val] + 1;
                    break;
                }
                c++;
                head = head.next;
            }
            return res > 0;

        }

        public bool hasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false; // No cycle if there are less than two nodes.
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next; // Move one step.
                fast = fast.next.next; // Move two steps.

                if (slow == fast)
                {
                    return true; // Cycle detected.
                }
            }

            return false; // No cycle found.
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value = 0, ListNode nextNode = null)
        {
            this.val = value;
            this.next = nextNode;
        }
    }
}
