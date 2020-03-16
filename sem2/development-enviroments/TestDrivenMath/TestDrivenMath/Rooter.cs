using System;

namespace TestDrivenMath
{
    public class Rooter
    {
        public Rooter()
        {
        }

        public double SquareRoot(double input)
        {
            // from creation of the method
            //throw new NotImplementedException();

            // original try
            //return input / 2;

            if(input < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            { 
                double result = input;
                double previousResult = -input;
                while (Math.Abs(previousResult - result) > result / 1000)
                {
                    previousResult = result;
                    // complex try : change result with a fraction of the error
                    //result = result - (result * result - input) / (2 * result);
                    // in both cases : Stable when result * result = input
                    result = (result + input / result) / 2;
                }
                return result;
            }
        }
    }
}