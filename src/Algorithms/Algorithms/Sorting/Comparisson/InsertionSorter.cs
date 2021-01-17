namespace Algorithms.Sorting.Comparisson
{
    using System.Collections.Generic;
    /// <summary>
    /// Class implementing insertion sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public class InsertionSorter<T> : IComparissonSorter<T>
    {
        /// <summary>
        /// Sorts the array with specific comparer.
        /// Stable : Yes
        /// Time Complexity:
        /// Best: O(n)  Average: O(n^2)   Worst: O(n^2)
        /// Method: Insertion 
        /// Memory: O(1)
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <param name="comparer">Compares elements</param>    
        public void Sort(T[] array, IComparer<T> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && comparer.Compare(array[j], key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}