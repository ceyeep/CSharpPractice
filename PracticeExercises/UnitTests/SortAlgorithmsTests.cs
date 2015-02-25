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
            SortAlgorithms.BubbleSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestInsertionSort()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            originalList = SortAlgorithms.InsertionSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestInsertionSortEmptyList()
        {
            originalList = new List<int>();
            originalList = SortAlgorithms.InsertionSort(originalList);
            CollectionAssert.AreEqual(new List<int>(), originalList);

        }

        [TestMethod]
        public void TestInsertionSortInPlace()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            SortAlgorithms.InsertionSortInPlace(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestSelectionSort()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            SortAlgorithms.SelectionSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestMergeSort()
        {
            originalList = new List<int>(new int[] { 5, 4, 3, 1, 2 });
            originalList = SortAlgorithms.MergeSort(originalList);
            CollectionAssert.AreEqual(sortedList, originalList);

        }

        [TestMethod]
        public void TestMergeSortEmptyList()
        {
            originalList = new List<int>();
            originalList = SortAlgorithms.InsertionSort(originalList);
            CollectionAssert.AreEqual(new List<int>(), originalList);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] originalList = new int[] { 5, 3, 4, 1, 2 };
            SortAlgorithms.QuickSort(originalList,0,originalList.Length-1);
            CollectionAssert.AreEqual(sortedList.ToArray(), originalList);

        }
    }
}
