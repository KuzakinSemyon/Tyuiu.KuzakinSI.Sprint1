using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KuzakinSI.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            {
                double ctg3x = 1.0 / Math.Tan(3 * x);
                double numerator = Math.Log(Math.Cos(x));
                double denominator = Math.Log(1 + x * x);
                double result = 2 * ctg3x - numerator / denominator;

                return Math.Round(result, 3);
            }
        }
    }
}
