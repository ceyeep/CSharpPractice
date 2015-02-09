using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercises;
using System;
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
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            SortAlgorithms.bubbleSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestInsertionSort()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            originalList = SortAlgorithms.insertionSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestInsertionSortInPlace()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            SortAlgorithms.insertionSortInPlace(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }
    }
}
