using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;
using System.Net;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree1 = new Tree(1);
            var tree2 = new Tree(2);
            var tree3 = new Tree(3);
            var tree4 = new Tree(4);
            tree1.AddConnection(tree2);
            tree1.AddConnection(tree3);
            tree2.AddConnection(tree4);
            //tree4.AddConnection(tree1);

            BreadthFirstSearch.Traverse(tree1);
            DepthFirstSearch.Traverse(tree1);

            var binaryTreecoc = new BinaryTreeCocoon();
            binaryTreecoc.Insert(100);
            binaryTreecoc.Insert(10);
            binaryTreecoc.Insert(200);
            binaryTreecoc.Insert(400);
            binaryTreecoc.Insert(50);
            binaryTreecoc.Insert(5);
            binaryTreecoc.Insert(8);
            binaryTreecoc.Insert(1);
            binaryTreecoc.Traverse();
            binaryTreecoc.ReversTraverse();
            binaryTreecoc.LeftViewTraverse();
            binaryTreecoc.RightViewTraverse();


            var linkedlist = new CustomLinkedList(1);
            linkedlist.Next = new CustomLinkedList(2);
            linkedlist.Next.Next = new CustomLinkedList(3);
            linkedlist.Next.Next.Next = linkedlist.Next;

            var ops = new LinkedListOperations();
            Console.WriteLine("\r\nCheckCycle");
            Console.WriteLine(ops.CheckIfCyclic(linkedlist));
            ops.BreakCheckIfCyclic(linkedlist);

            var mimStack = new MinimumStackOrderOfOne();
            Console.WriteLine("\r\nMinimumStack");
            mimStack.Push(10);
            mimStack.Push(100);
            Console.WriteLine(mimStack.GetMinimum());
            mimStack.Push(5);
            mimStack.Push(20);
            mimStack.Push(30);
            Console.WriteLine(mimStack.GetMinimum());
            mimStack.Pop();
            mimStack.Pop();
            mimStack.Pop();
            Console.WriteLine(mimStack.GetMinimum());
            mimStack.Push(10000);
            mimStack.Push(50);

           var data = new SortedArrayToBST().Run();

            var sortedss = SelectionSort.Sort(new int[] { 100, 200, 20, 4, 10, 35, });
            Console.WriteLine($"\r\nSelectionSort : {JsonConvert.SerializeObject(sortedss)} \r\n");
            var sortedis = InsertionSort.Sort(new int[] { 100, 200, 20, 4, 10, 35, });
            Console.WriteLine($"\r\nInsertionSort : {JsonConvert.SerializeObject(sortedis)} \r\n");

            var arr = new int[] { 100, 200, 20, 4, 10, 35, };
            Console.WriteLine($"\r\nHeapSortSort Initials : {JsonConvert.SerializeObject(arr)} \r\n");
            var sortedhs = HeapSort.Sort(arr);
            Console.WriteLine($"\r\nHeapSortSort : {JsonConvert.SerializeObject(sortedhs)} \r\n");
            var ar2 = new int[] { 100, 200, 20, 4, 10, 35, };
            var sortedhs2 = HeapSort.Sort2(ar2);
            Console.WriteLine($"\r\nHeapSortSortGeks : {JsonConvert.SerializeObject(sortedhs2)} \r\n");


            var ar3 = new int[] { 100, 200, 20, 4, 10, 35, };
            var sortedqs = QuickSort.Sort(ar2);
            Console.WriteLine($"\r\n QuickSort : {JsonConvert.SerializeObject(sortedqs)} \r\n");

            Console.ReadKey();
            
        }

        static void test()
        {
            int ch;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.google.com");
            var res = (HttpWebResponse)req.GetResponse();
            Stream str = res.GetResponseStream();
            for (int j = 1; ; j++)
            {
                ch = str.ReadByte();
                if (ch == -1)
                {
                    break;
                }
                Console.Write((char)ch);
                if ((j % 400) == 0)
                {
                    Console.WriteLine("\n PRess Enter");
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Hello World!");
            var hack = new TestHack();
            foreach (char val in hack)
                Console.Write(val + " ");

            Stack q = new Stack();
            q.Push("cshar");
            q.Push(7.3);
            q.Push(8);
            q.Push('b');
            q.Push(true);
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());
            Console.ReadLine();
        }
    }

    class TestHack
    {
        char val = 'X';
        public IEnumerator GetEnumerator()
        {
            for (int i = 20; i >= 0; --i)
                yield return (char)((val + i));
        }
    }

}
