using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MinimumStackOrderOfOne
    {
        private Stack<int> MainStack;
        private Stack<int> SupportingStack;

        public MinimumStackOrderOfOne()
        {
            MainStack = new Stack<int>();
            SupportingStack = new Stack<int>();
        }

        public void Push(int ele)
        {
            MainStack.Push(ele);
            if (SupportingStack.Count == 0 || SupportingStack.Peek() > ele)
                SupportingStack.Push(ele);
        }

        public int Pop()
        {
            var pop = MainStack.Pop();
            if (pop == SupportingStack.Peek())
                SupportingStack.Pop();

            return pop;
        }

        public int GetMinimum()
        {
            if (SupportingStack.Count > 0)
                return SupportingStack.Peek();
            return 0;
        }
    }
}
