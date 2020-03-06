using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class BreadthFirstSearch
    {
        public static void Traverse(Tree tree)
        {
            Console.WriteLine("\r\nBreadthFirstSearch\r\n");

            Queue<Tree> queue = new Queue<Tree>();
            HashSet<Tree> trees = new HashSet<Tree>();
            queue.Enqueue(tree);
            trees.Add(tree);

            while(queue.Count > 0 )
            {
                var qt = queue.Dequeue();
                Console.Write($" {qt.Data} ");
                foreach(var child in qt.Connections)
                {
                    if(!trees.Contains(child))
                    {
                        queue.Enqueue(child);
                        trees.Add(child);
                    }
                }
            }
        }
    }
}
