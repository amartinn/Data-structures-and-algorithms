using Algorithms.Sorting.Comparisson;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortingObject[] array = new SortingObject[100];
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                array[i] = new SortingObject
                {
                    Property = i,
                };
            }

            IComparissonSorter<SortingObject> sorter = new InsertionSorter<SortingObject>();
            SortingComparer comparer = new SortingComparer();
            sorter.Sort(array,comparer);

            IEnumerable<int> result = array.Select(x => x.Property);
            Console.WriteLine(string.Join(Environment.NewLine,result));

            var actualResult = Enumerable.Range(0, 100).ToList();
            // checks the sorting.
            for (int i = 0; i < actualResult.Count(); i++)
            {
                var isEqual = actualResult[i] == array[i].Property;
                if (!isEqual)
                {
                    throw new ArgumentNullException();
                }
            }
        }
    }

    public class SortingObject
    {
        public int Property { get; set; }
    }
    public class SortingComparer : IComparer<SortingObject>
    {
        public int Compare(SortingObject first, SortingObject second)
            => first.Property.CompareTo(second.Property);
    }
}
