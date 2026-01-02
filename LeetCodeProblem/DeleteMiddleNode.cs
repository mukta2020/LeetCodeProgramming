using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class DeleteMiddleNode
    {
        public static ListNode DeleteMiddle(ListNode head)
        {
            ListNode root = head;
            ListNode reformLink = head;
            ListNode reformLinkroot = reformLink;

            int count = 0;
            List<int> values = new List<int>();
            while (head != null)
            {
                count++;
                values.Add(head.val);
                head = head.next;
            }
            if (count == 1)
            {
                return null;
            }
            int mid = count / 2;
            count = 1;
            while (root != null)
            {
                if (count != mid)
                {
                    reformLink.next = root.next;
                    reformLink = reformLink.next;
                }
                count++;
                root = root.next;
            }

            return reformLinkroot;
        }

    }

   
}
