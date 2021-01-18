namespace Algorithms.Sorting.Comparisson
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Implementing quick sort algorithm.
    /// </summary>
    /// <typeparam name="T">The type of array element.</typeparam>
    public class QuickSorter<T> : IComparissonSorter<T>
    {
        private int left;
        private int right;

        public QuickSorter(int left, int right)
        {
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Gets or sets starting Index.
        /// </summary>
        public int Left
        {
            get => this.left;
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The given index is invalid!");
                }

                this.left = value;
            }
        }

        /// <summary>
        /// Gets or sets ending index.
        /// </summary>
        public int Right
        {
            get => this.right;
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The given index is invalid!");
                }

                this.right = value;
            }
        }

        /// <summary>
        /// Sorts the array with specific comparer.
        /// Stable : Depends
        /// Time Complexity:
        /// Best: O(n*log(n))  Average: O(n*log(n))   Worst: O(n^2)
        /// Method: Partition
        /// Memory: O(log(n))
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <param name="comparer">Compares elements</param>
        public void Sort(T[] array, IComparer<T> comparer)
            => this.Sort(array, comparer, this.Left, this.Right);

        private void Sort(T[] array, IComparer<T> comparer, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = this.Partition(array, comparer, left, right);

                this.Sort(array, comparer, left, partitionIndex - 1);
                this.Sort(array, comparer, partitionIndex + 1, right);
            }
        }

        private int Partition(T[] array, IComparer<T> comparer, int left, int right)
        {
            T pivot = array[right];
            int leftIndex = left - 1;

            for (int j = left; j < right; j++)
            {
                bool isLowerOrEqual = comparer.Compare(array[j], pivot) <= 0;
                if (isLowerOrEqual)
                {
                    leftIndex++;

                    this.Swap(array, leftIndex, j);
                }
            }

            this.Swap(array, leftIndex + 1, right);

            return leftIndex + 1;
        }

        private void Swap(T[] array, int firstIndex, int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
