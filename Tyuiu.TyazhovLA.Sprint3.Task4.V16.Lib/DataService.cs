using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) break;
                y *= ((Math.Cos(i) + i) / i) + 0.25;
            }
            return Math.Round(y,3);
        }
    }
}
