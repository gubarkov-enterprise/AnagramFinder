using System;
using System.Collections.Generic;
using System.Linq;

namespace AnagramFinder
{
    public static class Extensions
    {
        public static IEnumerable<string[]> GroupByAnagram(this string[] strings)
        {
            var anagramGroups = strings
                    .Select(Selector)
                    .GroupBy(tuple => tuple.asciiSum)
                ;
            foreach (var group in anagramGroups)
            {
                yield return group
                    .Select(tuple => tuple.value)
                    .ToArray();
            }
        }

        private static (int asciiSum, string value) Selector(string value) =>
            (value
                    .ToLower()
                    .Select(Convert.ToInt32)
                    .Sum(),
                value);
    }
}