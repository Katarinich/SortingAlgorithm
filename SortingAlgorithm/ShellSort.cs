using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithm
{
    class ShellSort : ISortAlgorithm
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparison<T> comparison)
        {
            var result = list.ToList();

            var step = result.Count / 2;
            while (step > 0)
            {
                for (var i = 0; i < (result.Count - step); i++)
                {
                    var j = i;
                    while (j >= 0 && comparison(result[j], result[j + step]) > 0)
                    {
                        var tmp = result[j];
                        result[j] = result[j + step];
                        result[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }

            return result.ToList().AsEnumerable();
        }

        public IEnumerable<T> Sort<T>(IEnumerable<T> list, Comparer<T> comparer)
        {
            var result = list.ToList();

            var step = result.Count / 2;
            while (step > 0)
            {
                for (var i = 0; i < (result.Count - step); i++)
                {
                    var j = i;
                    while (j >= 0 && comparer.Compare(result[j], result[j + step]) > 0)
                    {
                        var tmp = result[j];
                        result[j] = result[j + step];
                        result[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }

            return result.ToList().AsEnumerable();
        }
    }
}
