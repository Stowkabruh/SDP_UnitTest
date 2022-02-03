using System;

namespace CheckPrime
{
        public static class CheckPrimes
        {
            public static bool IsPrime(int number)
            {
                if (number < 0)
                {
                    throw new ArgumentException("Number cannot be negative");
                }
                if (number == 0 || number == 1)
                {
                    return false;
                }
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
}
