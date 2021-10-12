using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Primtal
{
    // Jag valde Lista som datastruktur då den hela tiden skall uppdateras/ändras
    internal static class PrimeList
    {
        private static List<int> _list;
        

        static PrimeList()
        {
            // Allocate the list.
            _list = new List<int>();
        }
        /// <summary>
        /// Sparar värdet i listan
        /// </summary>
        /// <param name="value"></param>
        public static void Record(int value)
        {
            _list.Add(value);
        }
        /// <summary>
        /// Ger högsta värdet i listan som int
        /// </summary>
        /// <returns></returns>
        public static int HighestPrimeInList()
        {
            
            if (_list.Count != 0)
            {
                _list.Sort();
                return _list.Last() + 1;
            }
            return 1;// Finns inget i listan skickar jag vidare 1
        }
        /// <summary>
        /// Kopierar orginallistan sorterar, tar bort dubletter och "renderar"
        /// </summary>
        public static void SortAndDisplay()
        {
            List<int> uniqeLst = _list.Distinct().ToList();
            uniqeLst.Sort();
            foreach (var value in uniqeLst)
            {
                Console.WriteLine(value);
            }
        }

    }
}