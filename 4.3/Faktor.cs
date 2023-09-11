using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    internal static class Faktor


    {
        public static int Factorial(this int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int result = n * Factorial(n - 1);
                return result;
            }
        }

        public static int PowerOf(this int n, int p)
        {
            return (int)Math.Pow(n, p);
        }
    }
}
