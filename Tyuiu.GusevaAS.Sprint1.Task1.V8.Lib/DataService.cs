using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GusevaAS.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {
            double result = (x * Math.PI) / a;
            return Math.Round(result, 2);
        }
    }
}
