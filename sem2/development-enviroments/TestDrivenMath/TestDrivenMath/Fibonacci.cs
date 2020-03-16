using System;

namespace TestDrivenMath
{
    public class Fibonacci
    {
        // Leonardo of Pisa was called Fibonacci (short for "filius Bonacci") 
        public Fibonacci()
        {
        }

        public int Get(int number)
        {
            // from creation of the method
            //throw new NotImplementedException();

            // fibonacci number 47 is 2971215073 which is too large for an integer (and a prime number);
            // the sequence may actually be expanded to negative numbers
            if (number < 0 || number > 46)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (number == 0) return 0;
                else if (number == 1) return 1;
                // original recursive; very slow for large number (e.g. 55 sec for number = 46)
                //else return Get(number - 1) + Get(number - 2);
                // fast iterative
                else
                {
                    int fa = 0;
                    int fb = 0;
                    int fc = 1;
                    for (int n = 2; n <= number; n++)
                    {
                        fa = fb;
                        fb = fc;
                        fc = fa + fb;
                    }
                    return fc;
                }
            }
        }
    }
}