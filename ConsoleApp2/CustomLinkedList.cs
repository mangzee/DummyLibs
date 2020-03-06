using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class CustomLinkedList
    {
        public int Data { get; set; }
        public CustomLinkedList Next;
        public CustomLinkedList(int data)
        {
            Data = data;
        }
    }
}
