using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class LinkedListOperations
    {
        public bool CheckIfCyclic(CustomLinkedList customLinkedList)
        {
            if (customLinkedList == null || customLinkedList.Next == null)
                return false;

            var slow = customLinkedList.Next;
            var fast = customLinkedList.Next.Next;

            while(fast != null && fast.Next != null)
            {
                if (fast == slow)
                    return true;

                fast = fast.Next.Next;
                slow = slow.Next;
            }
            return false;
        }

        public void BreakCheckIfCyclic(CustomLinkedList customLinkedList)
        {
            Console.WriteLine("\r\nBreakCycles\r\n");
            if (customLinkedList == null || customLinkedList.Next == null)
                Console.WriteLine($" {customLinkedList.Data} ");
            else
            {
                var slow = customLinkedList.Next;
                var fast = customLinkedList.Next.Next;

                while (fast != null && fast.Next != null)
                {
                    if (fast == slow)
                        break;

                    fast = fast.Next.Next;
                    slow = slow.Next;
                }
                if(fast == slow)
                {
                    while(slow.Next != fast.Next)
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                    fast.Next = null;
                }
                var current = customLinkedList;
                while(current != null)
                {
                    Console.Write($" {current.Data} ");
                    current = current.Next;
                }
            }
        }
    }
}
