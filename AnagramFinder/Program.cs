using System;
using System.Linq;

namespace AnagramFinder
{
    class Program
    {
        private static string[] _input =
        {
            "ток", "рост", "кот", "торс", "Кто", "фывап", "рок"
        };

        static void Main(string[] args)
        {
            foreach (var strings in _input.GroupByAnagram())
            {
                Console.WriteLine(string.Join(",", strings));
            }

            Console.ReadLine();
        }
    }
}