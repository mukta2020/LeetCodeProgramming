using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class ReverseList
    {
        public static ListNode ReverseList2(ListNode head)
        {
            // 1 -> 2 -> 3
            ListNode Prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = null;
                if (curr.next != null)
                {
                    nextTemp = curr.next; // 2 -> 3 store at temp
                }
                curr.next = Prev; // 1 <- 2
                Prev = curr; // 1
                curr = nextTemp; // curr restore from temp 2 -> 3
            }
            return Prev;
        }


        public static ListNode ReverseList1(ListNode head)
        {
            List<int> fList = new List<int>();
            while (head != null)
            {
                fList.Add(head.val);
                head = head.next;
            }


            ListNode root = new ListNode(fList.LastOrDefault());
            head = root;

            for (int i = fList.Count - 2; i >= 0; i--)
            {
                ListNode l = new ListNode(fList[i]);
                head.next = l;
                head = l;
            }
            return root;
        }


    }
}
