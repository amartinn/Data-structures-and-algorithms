namespace Algorithms.Sorting.Comparisson
{
    using System.Collections.Generic;

    /// <summary>
    /// Sorting an array in ascending order <typeparamref name="T"/> using comparisson sort.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparissonSorter<T>
    {
        /// <summary>
        /// Sorts an array of <typeparamref name="T"/> using a comparer in ascending order.
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <param name="comparer">Comparer to compare elements of <paramref name="array"/></param>
        void Sort(T[] array, IComparer<T> comparer);
    }
}