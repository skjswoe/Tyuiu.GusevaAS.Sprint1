using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.GusevaAS.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int maxDigit = 0;
            while (k > 0)
            {
                int digit = k % 10;  
                if (digit > maxDigit)
                    maxDigit = digit;
                k = k / 10;  
            }

            return maxDigit;
        }
    }
}
