namespace Algorithms.Sorting.Comparisson
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class implementing merge sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public class MergeSorter<T> : IComparissonSorter<T>
    {
        /// <summary>
        /// Sorts the array with specific comparer.
        /// Stable : Yes
        /// Time Complexity:
        /// Best: O(n*log(n))   Average: O(n*log(n))  Worst: O(n*log(n))
        /// Method: Merging
        /// Memory: O(1 or n)
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        /// <param name="comparer">Compares elements.</param>
        public void Sort(T[] array, IComparer<T> comparer)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int midPoint = array.Length / 2;
            T[] leftSide = new T[midPoint];
            T[] rightside = new T[array.Length - midPoint];

            // copy the elements of the array from 0 to midPoint into leftSideArray.
            Array.Copy(array, 0, leftSide, 0, midPoint);

            // copy the elements of the array from midpoint to (n - midpoint) where n is the length of the array.
            Array.Copy(array, midPoint, rightside, 0, array.Length - midPoint);


            this.Sort(leftSide, comparer);
            this.Sort(rightside, comparer);
            this.Merge(array, leftSide, rightside, comparer);
        }

        private void Merge(T[] array, T[] left, T[] right, IComparer<T> comparer)
        {
            int mainIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                bool isLowerOrEqual = comparer.Compare(left[leftIndex], right[rightIndex]) <= 0;
                array[mainIndex++] = isLowerOrEqual ? left[leftIndex++] : right[rightIndex++];
            }

            while (leftIndex < left.Length)
            {
                array[mainIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                array[mainIndex++] = right[rightIndex++];
            }
        }
    }
}
