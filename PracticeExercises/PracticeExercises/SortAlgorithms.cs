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
        public static void bubleSort(List<int> list)
        {
            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < (list.Count()) - 1; i++)
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
    }
}
