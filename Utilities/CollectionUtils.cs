﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class CollectionUtils
    {
        private static readonly Random _random = new Random();

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var o in enumerable)
                action(o);
        }

        public static void ForEach<T, U>(this IEnumerable<T> enumerable, Func<T, U> action)
        {
            foreach (var o in enumerable)
                action(o);
        }

        public static bool ContainsOne<T>(this IEnumerable<T> enumerable, Func<T,bool> predicate)
        {
            var count = enumerable.Count(predicate);
            return count == 1;
        }

        public static void RemoveIf<T>(this ICollection<T> collection, Func<T, bool> predicate)
        {
            foreach (var item in collection.ToArray())
            {
                if (predicate(item))
                    collection.Remove(item);
            }
        }
    }
}

