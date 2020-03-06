using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class QuickSort
    {
        public static int[] Sort(int[] nums)
        {
            QuickSorted(0, nums.Length - 1, nums);
            return nums;
        }

        private static void QuickSorted(int low,int high,int[] nums)
        {
            if(low < high)
            {
                var partition = Partition(low, high, nums);
                QuickSorted(low, partition, nums);
                QuickSorted(partition + 1, high, nums);
            }
        }

        private static int Partition(int low,int high,int[] arr)
        {
            var pivot = arr[low];
            var i = low;
            var j = high;
            while(i < j)
            {
                do
                {
                    i++;
                } while (arr[i] <= pivot);

                do
                {
                    j--;
                } while (arr[j] > pivot);

                if(i < j )
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            arr[low] = arr[j];
            arr[j] = pivot;
            return j;
        }
    }
}
