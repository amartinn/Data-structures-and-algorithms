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
            SortingObject[] array = new SortingObject[10];
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                array[i] = new SortingObject
                {
                    Name = $"name{i}",
                };
            }

            IComparissonSorter<SortingObject> sorter = new SelectionSorter<SortingObject>();
            SortingComparer comparer = new SortingComparer();
            sorter.Sort(array,comparer);

            IEnumerable<string> result = array.Select(x => x.Name);
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }

    public class SortingObject
    {
        public string Name { get; set; }
    }
    public class SortingComparer : IComparer<SortingObject>
    {
        public int Compare(SortingObject first, SortingObject second)
            => first.Name.CompareTo(second.Name);
    }
}
