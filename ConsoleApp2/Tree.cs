using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Tree
    {
        public int Data { get; set; }
        public List<Tree> Connections { get; set; }

        public Tree(int data)
        {
            this.Data = data;
            Connections = new List<Tree>();
        }

        public void AddConnection(Tree tree)
        {
            if(!Connections.Any(c=>c.Data == tree.Data))
                Connections.Add(tree);
        }
    }
}
