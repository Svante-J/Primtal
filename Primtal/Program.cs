using System;


namespace Primtal
{
    internal class Program 
    {
        private const string inputMsg = ("enter postitive number");
        private static readonly string inputErrorMsg = ($" is not accepted\n {inputMsg}");
        

        private static void Main(string[] args)
        {
            bool isNotPrime = false;
            // var calculateMe = 6;
            while (true)
            {

                Console.WriteLine(inputMsg);
                var input = Console.ReadLine();
                bool success = int.TryParse(input, out int result);
                if (success && result > 0 )
                {
                    
                        Console.WriteLine($"converted '{input}' to {result}");                        
                    
                }
                else
                {
                    Console.WriteLine($" '{input}'{inputErrorMsg}");
                    success = false;
                    
                }

                // kollar parsing, att värdet inte är ett för att sen testa om det är ett primtal
                if (success &&  result >= 2 && Primes.CalculatePrime(result))
                {
                    Console.WriteLine($"{result} is a prime number");
                    PrimeList.Record(result);
                    Console.ReadLine();
                    isNotPrime = false;
                }
                else if (success)
                {
                    Console.WriteLine($"{result} is not a prime");
                    Console.ReadLine();
                    isNotPrime = true;

                }
                if(isNotPrime)
                {
                var foundPrime = Primes.CalculateNextPrime(result);
                PrimeList.Record(foundPrime);
                Console.WriteLine($"but {foundPrime} is and have been added to the list!");
                }

                Console.WriteLine("här kommer listan");
                
                //todo: menyer
                //söka nästa primtal
                // PrimeList.Display();

                PrimeList.SortAndDisplay();
                Console.ReadLine();
            }
        }
    }
}