using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    /// <summary>
    /// Sort algorithms.
    /// </summary>
    public class SortAlgorithms
    {
        /// <summary>
        /// Bubble sort algorithm O(n^2)
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleSort(List<int> list)
        {
            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < (list.Count) - 1; i++)
                {
                    if (list[i + 1] < list[i])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        changed = true;
                    }
                }
            }
            while (changed);
        }

        /// <summary>
        /// Insertion sort O(n^2) space complexity O(n)
        /// </summary>
        /// <param name="originalList"></param>
        public static List<int> InsertionSort(List<int> originalList)
        {
            List<int> sortedList = new List<int>();

            if (originalList.Count > 1)
            {
                sortedList.Insert(0, originalList[0]);

                for (int i = 1; i < originalList.Count; i++)
                {

                    for (int j = 0; j < sortedList.Count; j++)
                    {
                        if (originalList[i] < sortedList[j])
                        {
                            sortedList.Insert(j, originalList[i]);
                            break;
                        }
                    }
                }
                return sortedList;
            }
            return originalList;
        }

        /// <summary>
        /// Insertion sort in place O(n^2)
        /// </summary>
        /// <param name="list"></param>
        public static void InsertionSortInPlace(List<int> list)
        {

            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (list[i] < list[j])
                        {
                            list.Insert(j, list[i]);
                            list.RemoveAt(i + 1);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Selection sort O(n^2).
        /// </summary>
        /// <param name="list"></param>
        public static void SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = list[i];
                int minPos = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < min)
                    {
                        min = list[j];
                        minPos = j;
                    }
                }
                list.Insert(i, min);
                list.RemoveAt(minPos + 1);
            }
        }

        /// <summary>
        /// Merge sort O(n log n)
        /// </summary>
        /// <param name="list"></param>
        public static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;
            else
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();
                int mid = list.Count / 2;
                left = list.GetRange(0, mid);
                right = list.GetRange(mid, list.Count - mid);
                list = Merge(MergeSort(left), MergeSort(right));
                return list;
            }
        }

        /// <summary>
        /// Merge step from Merge sort.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> sortedList = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    sortedList.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    sortedList.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            
            while (left.Count > 0)
            {

                sortedList.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {

                sortedList.Add(right[0]);
                right.RemoveAt(0);
            }

            return sortedList;
        }
    }
}
