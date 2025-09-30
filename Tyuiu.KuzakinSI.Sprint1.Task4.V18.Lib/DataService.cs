using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KuzakinSI.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Sqrt(3 + x) / Math.Pow(x * y, 2), 3);
        }
    }
}
