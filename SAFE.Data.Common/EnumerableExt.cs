using System.Collections.Generic;

namespace SAFE.Data.Utils
{
    public static class EnumerableExt
    {
        public static IEnumerable<ulong> LongRange(ulong start, ulong count)
        {
            var end = start + count;
            for (var current = start; current < end; ++current)
                yield return current;
        }
    }
}