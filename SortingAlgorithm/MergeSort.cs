using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithm
{
    class MergeSort : ISortAlgorithm
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparison<T> comparison)
        {
            var result = list.ToList();

            if (result.Count == 1)
            {
                return result.AsEnumerable();
            }

            var midPoint = result.Count / 2;
            var a = result.Take(midPoint).ToList().AsEnumerable();
            var b = result.Skip(midPoint).ToList().AsEnumerable();

            return Merge(Sort(a, comparison).ToList(), Sort(b, comparison).ToList(), comparison).AsEnumerable();
        }

        private List<T> Merge<T>(IReadOnlyList<T> firstList, IReadOnlyList<T> secondList, Comparison<T> comparison)
        {
            int a = 0, b = 0;
            var merged = new T[firstList.Count + secondList.Count];
            for (var i = 0; i < firstList.Count + secondList.Count; i++)
            {
                if (b.CompareTo(secondList.Count) < 0 && a.CompareTo(firstList.Count) < 0)
                {
                    if (comparison(firstList[a], secondList[b]) > 0)
                    {
                        merged[i] = secondList[b++];
                    }
                    else
                    {
                        merged[i] = firstList[a++];
                    }
                }
                else if (b < secondList.Count)
                {
                    merged[i] = secondList[b++];
                }
                else
                {
                    merged[i] = firstList[a++];
                }
            }
            return merged.ToList();
        }

        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparer<T> comparer)
        {
            var result = list.ToList();

            if (result.Count == 1)
            {
                return result.AsEnumerable();
            }

            var midPoint = result.Count / 2;
            var a = result.Take(midPoint).ToList().AsEnumerable();
            var b = result.Skip(midPoint).ToList().AsEnumerable();

            return Merge(Sort(a, comparer).ToList(), Sort(b, comparer).ToList(), comparer).AsEnumerable();
        }

        private List<T> Merge<T>(IReadOnlyList<T> firstList, IReadOnlyList<T> secondList, Comparer<T> comparer)
        {
            int a = 0, b = 0;
            var merged = new T[firstList.Count + secondList.Count];
            for (var i = 0; i < firstList.Count + secondList.Count; i++)
            {
                if (b.CompareTo(secondList.Count) < 0 && a.CompareTo(firstList.Count) < 0)
                {
                    if (comparer.Compare(firstList[a], secondList[b]) > 0)
                    {
                        merged[i] = secondList[b++];
                    }
                    else
                    {
                        merged[i] = firstList[a++];
                    }
                }
                else if (b < secondList.Count)
                {
                    merged[i] = secondList[b++];
                }
                else
                {
                    merged[i] = firstList[a++];
                }
            }
            return merged.ToList();
        }
    }
}
