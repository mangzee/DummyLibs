using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class HeapSort
    {
        public static int[] Sort(int[] nums)
        {
          return Heapify(nums,nums.Length);
        }

        public static int[] Sort2(int[] nums)
        {
            var n = nums.Length;
            // Build heap (rearrange array) 
            for (int i = n / 2 ; i >= 0; i--)
                heapify(nums, n, i);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;

                // call max heapify on the reduced heap 
                heapify(nums, i, 0);
            }

            return nums;
        }

        private static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i;
            int right = 2 * i + 1;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }

        private static int[] Heapify(int[] nums,int length)
        {
            for(var i = length - 1;i >=0; i--)
            {
                var leftChild = 2 * i;
                var rightChild = 2 * i + 1;
                if(leftChild < nums.Length && nums[i] < nums[leftChild])
                {
                    var temp = nums[i];
                    nums[i] = nums[leftChild];
                    nums[leftChild] = temp;
                }
                else if (rightChild < nums.Length && nums[i] < nums[rightChild])
                {
                    var temp = nums[i];
                    nums[i] = nums[rightChild];
                    nums[rightChild] = temp;
                }
            }
            return nums;
        }
    }
}
