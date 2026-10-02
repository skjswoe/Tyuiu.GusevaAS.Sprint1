using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GusevaAS.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double numerator = y * y + Math.Cos(x * x * x) + 12 * x * y - 3 * x * x;
            double denominator = Math.Cos(x * x * x + 3) + 18 * y - 1;

            double z = Math.Exp(x) - numerator / denominator;

            return Math.Round(z, 3);
        }
    }
}
