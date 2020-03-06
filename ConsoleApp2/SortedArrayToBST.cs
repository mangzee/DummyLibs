using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class SortedArrayToBST
    {
        public BinaryTree Run()
        {
            var input = new int[] { -1, 2, 10, 15, 30, 45 };
            return BuildBinaryTree(input, 0, input.Length - 1);

        }

        private BinaryTree BuildBinaryTree(int[] inputs,int low,int high)
        {
            if (low > high)
                return null;
            int mid = low + (high - low) / 2;
            BinaryTree tree = new BinaryTree(inputs[mid]);
            tree.Left = BuildBinaryTree(inputs, low, mid - 1);
            tree.Right = BuildBinaryTree(inputs, mid+1, high);
            return tree;
        }
    }
}
