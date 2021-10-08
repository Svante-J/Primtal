using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primtal
{
    static class PrimeList
    {
        static List<int> _list;
        static List<int> _uniqeList;

        static PrimeList()
        {
            // Allocate the list.
            _list = new List<int>();
            //_uniqeList = new List<int>();
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
        public static void SortAndDisplay()
        {
            List<int> uniqeLst = _list.Distinct().ToList();
            uniqeLst.Sort();
            foreach (var value in uniqeLst)
            {
                Console.WriteLine(value);
            }
        }
        public static void Sort()
        {
            List<int> uniqeLst = _list.Distinct().ToList();
            uniqeLst.Sort();
        }
    }
}
