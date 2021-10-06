using System;


namespace Primtal
{
    internal class Program 
    {
        private const string inputMsg = ("enter postitive number");
        private static readonly string inputErrorMsg = ($" is not accepted\n {inputMsg}");
        

        private static void Main(string[] args)
        {
            //bool isPrime = true;
            // var calculateMe = 6;
            while (true)
            {

                Console.WriteLine(inputMsg);
                var input = Console.ReadLine();
                bool success = int.TryParse(input, out int result);
                if (success)
                {
                    if (result > 0)
                    {
                        Console.WriteLine($"converted '{input}' to {result}");                        
                    }
                }
                else
                {
                    Console.WriteLine($" '{input}'{inputErrorMsg}");
                    
                }

                // kollar parsing, att värdet inte är ett för att sen testa om det är ett primtal
                if (success &&  result != 1 && Primes.CalculatePrime(result))
                {
                    Console.WriteLine($"{result} is a prime number");
                    PrimeList.Record(result);
                    Console.ReadLine();
                }
                else if (success)
                {
                    Console.WriteLine($"{result} is not a prime");
                    Console.ReadLine();
                }

                Console.WriteLine("här kommer listan");
                //todo sortera listan
                //todo: menyer
                //söka nästa primtal
                PrimeList.Display();
                Console.ReadLine();
            }
        }
    }
}