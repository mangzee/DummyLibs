using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class DepthFirstSearch
    {
        public static void Traverse(Tree tree)
        {
            var stack = new Stack<Tree>();
            var hashSet = new HashSet<Tree>();
            stack.Push(tree);
            hashSet.Add(tree);
            Console.WriteLine("\r\nDepthFirstSearch\r\n");
            while(stack.Count > 0)
            {
                var ele = stack.Pop();
                Console.Write($" {ele.Data} ");
                foreach(var data in ele.Connections)
                if(!hashSet.Contains(data))
                {
                    stack.Push(data);
                    hashSet.Add(data);
                }
            }
        }
    }
}
