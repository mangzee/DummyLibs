using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
           for(var i=0;i<numbers.Length-1;i++)
            {
                var min_key = i;
                for(var k=i;k<numbers.Length;k++)
                {
                    if (numbers[k] < numbers[min_key])
                        min_key = k;
                }

                var temp = numbers[i];
                numbers[i] = numbers[min_key];
                numbers[min_key] = temp;
            }

            return numbers;
        }
    }
}
