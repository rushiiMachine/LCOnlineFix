using System.Collections.Generic;
using System.Linq;

namespace LCOnlineFix;

internal static class Utils
{
    public static IEnumerable<T> AddFirst<T>(this IEnumerable<T> sequence, T item) =>
        new[] { item }.Concat(sequence ?? Enumerable.Empty<T>());
}