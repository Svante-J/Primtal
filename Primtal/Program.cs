using System;

namespace Primtal
{
    internal class Program
    {
        private const string inputMsg = ("enter postitive number or Q to quit");
        private static readonly string inputErrorMsg = ($" is not accepted");

        private static void Main(string[] args)
        {
            bool runProgram = true;
            bool isNotPrime = false;
            
            while (runProgram)
            {
                Console.WriteLine(inputMsg);
                var input = Console.ReadLine();
                bool success = int.TryParse(input, out int result);

                if ("Q" == input.ToUpper())
                {
                    Console.WriteLine("Hejdå");
                    runProgram = false;
                }
                else if (success && result > 0)
                {
                    Console.WriteLine($"converted '{input}' to {result}");
                }
                else
                {
                    Console.WriteLine($" '{input}'{inputErrorMsg}");
                    success = false;
                }

                
                if (success && result >= 2 && Primes.CalculatePrime(result))
                {
                    Console.WriteLine($"{result} is a prime number and [added to list]");
                    PrimeList.Record(result);
                    isNotPrime = false;
                }
                else if (success)
                {
                    Console.WriteLine($"{result} is not a prime number");
                    Console.ReadLine();
                    isNotPrime = true;
                }
                if (isNotPrime && success)
                {
                    Console.WriteLine("Would yoy like the computer to add a prime automagik?");
                    Console.WriteLine("[Y] for yes [Anything else] for no");
                    var addDecision = Console.ReadLine();
                    
                    if (string.Equals(addDecision, "Y", StringComparison.OrdinalIgnoreCase))
                    {
                        var foundPrime = Primes.CalculateNextPrime(PrimeList.HighestPrimeInList());
                        
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

                Console.WriteLine("här kommer listan");
                PrimeList.SortAndDisplay();
                Console.ReadLine();
                
                //todo: menyer
                //todo: Kommentera
                
            }
        }
    }
}