using System;
using System.Collections.Generic;
using System.Text;

namespace Primtal
{
    static class PrimeList
    {
        static List<int> _list;

        static PrimeList()
        {
            // Allocate the list.
            _list = new List<int>();
        }

        public static void Record(int value)
        {
            // Record this value in the list.
            _list.Add(value);
        }

        public static void Display()
        {
            // Write out the results.
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }
        }
        public static void Display2()
        {
            // Write out the results.
            foreach (var value in _list)
            {
                Console.Write(" " + value + " ");
            }
        }
    }
}
