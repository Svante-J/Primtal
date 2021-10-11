using System;

namespace Primtal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool runProgram = true;
            bool isNotPrime = false;

            while (runProgram)
            {
                
                
                var success = UserInput(out var result, ref runProgram);

                #region PrimeCalculations

                if (success && result >= 2 && Primes.CalculatePrime(result))
                {
                    Console.WriteLine($"{result} is a prime number and [added to list]");
                    PrimeList.Record(result);
                    isNotPrime = false;
                }
                else if (success)
                {
                    Console.WriteLine($"{result} is not a prime number");
                    isNotPrime = true;
                }
                if (isNotPrime && success)
                {
                    Console.WriteLine("Would yoy like the computer to add a prime automagik?");
                    Console.WriteLine("[Y] for yes [Anything else] for no");
                    Console.Write(">");
                    var addDecision = Console.ReadLine();

                    if (string.Equals(addDecision, "Y", StringComparison.OrdinalIgnoreCase))
                    {
                        var foundPrime = Primes.CalculateNextPrime(PrimeList.HighestPrimeInList());

                        // Calculate prime hanterar 1or som primtal
                        if (foundPrime == 1)
                        {
                            foundPrime++;
                            PrimeList.Record(foundPrime);
                            Console.WriteLine($"but {foundPrime} is and have been added to the list!");
                        }
                        else
                        {
                            PrimeList.Record(foundPrime);
                            Console.WriteLine($"but {foundPrime} is and have been added to the list!");
                        }
                    }
                }

                #endregion PrimeCalculations
                
                Console.WriteLine("Your Primes");
                PrimeList.SortAndDisplay();
                Console.ReadLine();

            }
        }


        /// <summary>
        /// Hanterar input från användaren
        /// </summary>
        /// <param name="result"></param>
        /// <param name="runProgram"></param>
        /// <returns></returns>
        private static bool UserInput(out int result, ref bool runProgram)
        {
            Console.WriteLine("enter positive number or Q to quit");
            var input = Console.ReadLine();
            var success = int.TryParse(input, out result);

            if (string.Equals("Q", input, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Bye Bye");
                runProgram = false;
            }
            else if (success && result > 0)
            {
                Console.WriteLine($"converted '{input}' to {result}");
            }
            else
            {
                Console.WriteLine($" '{input}' is not accepted");
                success = false;
            }

            return success;
        }
    }
}