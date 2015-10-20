using System;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    interface ISortAlgorithm
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparison<T> comparison);
        IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparer<T> comparer);
    }
}
