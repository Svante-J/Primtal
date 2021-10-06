namespace Primtal
{
    public static class Primes
    {

        /// <summary>
        /// tar emot en int och berättar om det är ett primtal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CalculatePrime(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }

                // add to list
            }
            return true;
        }
    }
}