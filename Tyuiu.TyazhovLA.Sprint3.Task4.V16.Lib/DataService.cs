using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) 
                {
                    continue;
                }
                else 
                { 
                    y = y * (((Math.Cos(x) + x) / x) + 0.25);
                }
            }
            return Math.Round(y,3);
        }
    }
}
