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
                //Uträkningen hanterar inte ettor så den fick en special
                if (input == 1) { return false; }

                //Är input delbart med något över ett och (sig själv -1) är det inget prim
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Letar Primtal stigande efter input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int CalculateNextPrime(int input)
        {
            isPrime = false;
            x = input;
            bool evenNumber = (input % 2 == 0);
            if (evenNumber)
            {
                x++; //onödigt att skicka vidare jämna nummer till CalculatePrime
            }
            while (!isPrime)
            {
                if (CalculatePrime(x))
                {
                    isPrime = true;
                }
                else
                {
                    x += 2; //håller sig på udda värden
                }
            }
            return x;
        }
    }
}