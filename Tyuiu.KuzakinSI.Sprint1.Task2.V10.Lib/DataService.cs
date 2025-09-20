using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KuzakinSI.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int meters)
        {
            return Math.Round(meters * 39.370079, 3);
        }
    }
}
