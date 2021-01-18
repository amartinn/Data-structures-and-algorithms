namespace Algorithms.Shuffling
{
    using System;

    /// <summary>
    /// Class implementing Fisher-Yates shuffling algorithm.
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public class FisherYatesShuffler<T> : IShuffler<T>
    {
        private readonly Random random = new Random();

        /// <summary>
        /// Shuffles the array.
        /// Stable : No
        /// Time Complexity:
        /// Best: O(n)  Average: O(n)   Worst: O(n)
        /// Method: Exchanging
        /// Memory: O(1)
        /// where n is the length of the array.
        /// </summary>
        /// <param name="array">The array to be shuffled.</param>
        public void Shuffle(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = this.random.Next(i);
                this.Swap(array, index, i);
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
