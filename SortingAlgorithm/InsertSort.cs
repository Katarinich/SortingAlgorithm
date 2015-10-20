using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class InsertSort : ISortAlgorithm
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparison<T> comparison)
        {
            var result = list.ToList();

            for (var i = 1; i < result.Count; i++)
            {
                var cur = result[i];
                var j = i;
                while (j > 0 && comparison(result[j - 1], cur) > 0)
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = cur;
            }

            return result.ToList().AsEnumerable();
        }

        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparer<T> comparer)
        {
            var result = list.ToList();

            for (var i = 1; i < result.Count; i++)
            {
                var cur = result[i];
                var j = i;
                while (j > 0 && comparer.Compare(result[j - 1], cur) > 0)
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = cur;
            }

            return result.ToList().AsEnumerable();
        }
    }
}
