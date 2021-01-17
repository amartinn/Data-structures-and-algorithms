namespace Algorithms.Sorting.Comparisson
{
    using System.Collections.Generic;
    /// <summary>
    /// Class implementing selection sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public class SelectionSorter<T> : IComparissonSorter<T>
    {
        /// <summary>
        /// Sorts the array with specific comparer.
        /// Stable : No
        /// Time Complexity:
        /// Best: O(n^2)  Average: O(n^2)   Worst: O(n^2)
        /// Method: Selection 
        /// Memory: O(1)
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <param name="comparer">Compares elements</param>
        public void Sort(T[] array, IComparer<T> comparer)
        {
            for (int i = 1; i < array.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    bool isLower = comparer.Compare(array[j], array[min]) < 0;
                    if (isLower)
                    {
                        min = j;
                    }
                    this.Swap(array, min, i);
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