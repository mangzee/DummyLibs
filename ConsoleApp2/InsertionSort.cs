using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] numbers)
        {
            for(var i = 1;i<numbers.Length;i++)
            {
                var item = numbers[i];
                var ins = 0;
                for(var j=i-1;j>=0 && ins != 1;)
                {
                    if (item < numbers[j])
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                        numbers[j + 1] = item;
                    }
                    else
                        ins = 1;
                }
            }

            return numbers;
        }
    }
}
