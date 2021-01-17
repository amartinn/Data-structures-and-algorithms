using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.Comparisson
{
    /// <summary>
    /// Class implementing bubble sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public sealed class BubbleSorter<T> : IComparissonSorter<T>
    {
        /// <summary>
        /// Sorts the array with specific comparer.
        /// Stable : Yes
        /// Time Complexity:
        /// Best: O(n)  Average: O(n^2)   Worst: O(n^2)
        /// Method: Exchanging 
        /// Memory: O(1)
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <param name="comparer">Compares elements</param>
        public void Sort(T[] array, IComparer<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool changed = false;
                for (int j = 0; j < array.Length - i -1; j++)
                {
                    T current = array[j];
                    T next = array[j + 1];
                    bool isGreater = comparer.Compare(current, next) > 0;
                    if (isGreater)
                    {
                        this.Swap(array, j, j + 1);
                        changed = true;
                    }
                }
                if (!changed)
                {
                    break;
                }
            }
        }

        private void Swap(T[] array, int firstIndex, int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}