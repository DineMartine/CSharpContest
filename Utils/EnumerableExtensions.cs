using System;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> IndexOf<T>(this IEnumerable<T> e, T o)
        {
            var idx = 0;
            foreach (var t in e)
            {
                if (Equals(t, o))
                    yield return idx;
                idx ++;
            }
        }

        public static IEnumerable<T> WhereMax<T, TResult>(this IEnumerable<T> e, Func<T, TResult> f)
        {
            var max = e.Max(t => f(t));
            return e.Where(t => Equals(f(t), max));
        }
    }
}
