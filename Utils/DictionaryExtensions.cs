using System;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public static class DictionaryExtensions
    {
        public static IEnumerable<KeyValuePair<TKey, TResult>> SelectValue<TKey, TSource, TResult>(this IEnumerable<KeyValuePair<TKey, TSource>> d,
            Func<TSource, TResult> f)
        {
            return d.Select(kv => new KeyValuePair<TKey, TResult>(kv.Key, f(kv.Value)));
        }

        public static IEnumerable<KeyValuePair<TResult, TValue>> SelectKey<TValue, TSource, TResult>(this IEnumerable<KeyValuePair<TSource, TValue>> d,
            Func<TSource, TResult> f)
        {
            return d.Select(kv => new KeyValuePair<TResult, TValue>(f(kv.Key), kv.Value));
        }

        public static IDictionary<TKey, TValue> ToDictionary<TKey, TValue>(
            this IEnumerable<KeyValuePair<TKey, TValue>> d)
        {
            return d.ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> d)
        {
            return new SortedDictionary<TKey, TValue>(d);
        }

        public static IDictionary<TKeyIn, IDictionary<TKeyOut, TValue>> Transpose<TKeyOut, TKeyIn, TValue>(this IDictionary<TKeyOut, IDictionary<TKeyIn, TValue>> dico)
        {
            var transposedDico = new Dictionary<TKeyIn, IDictionary<TKeyOut, TValue>>();
            foreach(var row in dico)
            {
                var keyOut = row.Key;
                foreach(var kv in row.Value)
                {
                    var kvIn = kv.Key;
                    IDictionary<TKeyOut, TValue> transposedRow;
                    if(!transposedDico.TryGetValue(kvIn, out transposedRow))
                    {
                        transposedRow = new Dictionary<TKeyOut, TValue>();
                        transposedDico.Add(kvIn, transposedRow);
                    }
                    transposedRow.Add(keyOut, kv.Value);
                }
            }
            return transposedDico;
        }
    }
}
