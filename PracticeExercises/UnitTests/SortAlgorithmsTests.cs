using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercises;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class SortAlgorithmsTests
    {
        List<int> originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
        List<int> sortedList = new List<int>(new int[] { 1, 2, 3, 4, 5 });

        [TestMethod]
        public void TestBubbleSort()
        {
            SortAlgorithms.bubleSort(originalList);
            CollectionAssert.Equals(sortedList, originalList);

        }
    }
}
