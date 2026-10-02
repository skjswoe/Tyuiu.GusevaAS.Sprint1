using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GusevaAS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double abs = Math.Abs(number);
            double fraction = abs - Math.Floor(abs);
            int digits = (int)(fraction * 1000);
            int d1 = digits / 100;
            int d2 = (digits / 10) % 10;
            int d3 = digits % 10;

            return d1 == 0 || d2 == 0 || d3 == 0;
        }
    }
}