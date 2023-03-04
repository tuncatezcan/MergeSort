using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            int n = arr.Length;

            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            MergeSort(arr, 0, n - 1);

            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static public void MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;

                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);

                Merge(arr, low, mid, high);
            }
        }

        static public void Merge(int[] arr, int low, int mid, int high)
        {
            int left = mid - low + 1;
            int right = high - mid;

            int[] leftArray = new int[left];
            int[] rightArray = new int[right];


            int i;
            int j;

            for (i = 0; i < left; i++)
            {
                leftArray[i] = arr[low + i];
            }

            for (j = 0; j < right; j++)
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = low;

            while (i < left && j < right)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < left)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < right)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
