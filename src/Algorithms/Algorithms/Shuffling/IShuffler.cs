namespace Algorithms.Shuffling
{
    /// <summary>
    /// Shuffling an array of type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Type of the array element.</typeparam>
    public interface IShuffler<T>
    {
        /// <summary>
        /// shuffle an array of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="array">Array to shuffle.</param>
        void Shuffle(T[] array);
    }
}
