using System;

namespace ExamHandin4_Test_Driven_Development
{
    //https://stackoverflow.com/questions/12949907/how-can-i-return-the-sum-average-of-an-int-array
    class Average
    {
        public int SumCalc(params int[] avg)
        {
            int result = 0;

            for (int i = 0; i < avg.Length; i++)
            {
                result += avg[i];
            }

            return result;
        }
        public double AverageCalc(params int[] avg)
        {
            int sum = SumCalc(avg);
            double result = (double)sum / avg.Length;
            return result;
        }
    }
}