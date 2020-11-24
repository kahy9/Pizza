using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public static class Utils
    {
        public static IEnumerable<T>Concat<T>(this IEnumerable<T> items, T item)
        {
            foreach (var i in items)
            {
                yield return i;
            }
            yield return item;
        }

        public static IEnumerable<T> ConcatOne<T>(this T item, IEnumerable<T> items)
        {
            yield return item;
            foreach (var i in items)
            {
                yield return i;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            int index = 0;
            foreach (var item in items)
            {
                action(item, index);
                index++;
            }
        }

        public static void ForEachIf<T>(this IEnumerable<T> items, Action<T> action, Func<T, bool> condition)
        {
            foreach (var item in items)
            {
                if (condition(item)) action(item);
            }
        }

        public static void ForEachIf<T>(this IEnumerable<T> items, Action<T, int> action, Func<T, int, bool> condition)
        {
            int index = 0;
            foreach (var item in items)
            {
                if (condition(item, index)) action(item, index);
                index++;
            }
        }
    }
}
