using System;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PLease enter number");

            Console.WriteLine("_");

            bool isPrime = true;

            if (isPrime)
            {
                Console.WriteLine("wihoo");
                myFuntion(5);
            }


        }

        private static bool myFuntion(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i ==0)
                {
                    return false;
                }

                // add to list
            }
            return true;
        }
    }
}
