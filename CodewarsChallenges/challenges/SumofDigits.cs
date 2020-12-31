using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class SumofDigits
    {


        public static int DigitalSum(long n)
        {

            int result = 0;
            while (n > 0)
            {
                result = result + (int)(n % 10);
                n = n / 10;
            }
            return result;
        }

        public static int DigitalRoot(long x)
        {
            while (x > 10)
            {
                x = DigitalSum(x);
            }
            return (int)x;
        }
    }
}
