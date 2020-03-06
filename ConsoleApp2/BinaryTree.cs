using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class BinaryTree
    {
        public int Data { get; set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public BinaryTree(int data)
        {
            Data = data;
        }
    }

    public class BinaryTreeCocoon
    {
        private BinaryTree Root;

        public void Insert(int Data)
        {
            if (Root == null)
                Root = new BinaryTree(Data);
            else
                InsertRecords(Root, new BinaryTree(Data));
        }

        public void Traverse()
        {
            Console.WriteLine("\r\nBinaryTreeTraversal\r\n");
            if (Root == null)
                Console.WriteLine("Empty");
            var queue = new Queue<BinaryTree>();
            var set = new HashSet<BinaryTree>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var ele = queue.Dequeue();
                Console.Write($" {ele.Data} ");
                if (ele.Left != null)
                {
                    queue.Enqueue(ele.Left);
                }
                if (ele.Right != null)
                    queue.Enqueue(ele.Right);
            }
        }

        public void ReversTraverse()
        {
            var queue = new Queue<BinaryTree>();
            var statck = new Stack<BinaryTree>();
            queue.Enqueue(Root);
            while(queue.Count > 0)
            {
                var ele = queue.Dequeue();
                if (ele.Right != null)
                    queue.Enqueue(ele.Right);
                if (ele.Left != null)
                    queue.Enqueue(ele.Left);
                statck.Push(ele);
            }

            Console.WriteLine($"\r\nReverseTraversal\r\n");

            while(statck.Count > 0)
            {
                Console.Write($" {statck.Pop().Data} ");
            }
        }

        public void LeftViewTraverse()
        {
            Console.WriteLine("\r\nBinaryTreeLeftViewTraversal\r\n");
            if (Root == null)
                Console.WriteLine("Empty");
            var dictionary = new Dictionary<int, BinaryTree>();

            LeftView(Root, 1, dictionary);
            foreach (var item in dictionary)
                Console.Write($" {item.Value.Data} ");
        }
        private void LeftView(BinaryTree tree,int level,Dictionary<int,BinaryTree> dict)
        {
            if (!dict.ContainsKey(level))
                dict.Add(level, tree);
            if(tree.Left != null)
             LeftView(tree.Left, level + 1, dict);
            if(tree.Right != null)
                LeftView(tree.Right, level + 1, dict);
        }
        public void RightViewTraverse()
        {
            Console.WriteLine("\r\nBinaryTreeRightViewTraversal\r\n");
            if (Root == null)
                Console.WriteLine("Empty");
            var dictionary = new Dictionary<int, BinaryTree>();

            RightView(Root, 1, dictionary);
            foreach (var item in dictionary)
                Console.Write($" {item.Value.Data} ");
        }
        private void RightView(BinaryTree tree, int level, Dictionary<int, BinaryTree> dict)
        {
            if (!dict.ContainsKey(level))
                dict.Add(level, tree);

            if(tree.Right != null)
                RightView(tree.Right, level + 1, dict);
            if(tree.Left != null)
                RightView(tree.Left, level + 1, dict);
        }



        private void InsertRecords(BinaryTree root,BinaryTree newNode)
        {
            if(newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                {
                    InsertRecords(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                {
                    InsertRecords(root.Right, newNode);
                }
            }
        }
    }
}
