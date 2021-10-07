namespace Primtal
{
    public static class Primes
    {
        private static bool isPrime;
        private static int x;


        /// <summary>
        /// tar emot en int och berättar om det är ett primtal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CalculatePrime(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input == 1) { return false; }

                if (input % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
        public static int CalculateNextPrime(int input)
        {
            isPrime = false;
            x = input;
            bool evenNumber = (input % 2 == 0);
            if(evenNumber)
            {
                x++;
            }
            while(!isPrime)
            {
                
                
                if (CalculatePrime(x))
                {
                    
                    isPrime = true;
                }
                else 
                { 
                x += 2; // 
                }

            }
            return x;
        }
}
}